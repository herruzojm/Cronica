using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Cronica.Modelos.ViewModels.PostPartidas;

namespace Cronica.Controllers
{
    [Authorize(Policy = "Jugador")]
    public class JugadoresController : RutasController
    {
        
        private IServicioJugadores _servicioJugadores;
        private IServicioUsuarios _servicioUsuarios;
        private IServicioTramas _servicioTramas;
        private readonly UserManager<ApplicationUser> _userManager;
        private IServicioAsignaciones _servicioAsignaciones;
        private IServicioPostPartidas _servicioPostPartidas;

        public JugadoresController(IServicioJugadores servicioJugadores, IServicioUsuarios servicioUsuarios,
                                    IServicioTramas servicioTramas, IServicioAsignaciones servicioAsignaciones,
                                    IServicioPostPartidas servicioPostPartidas, UserManager<ApplicationUser> userManager)
        {
            _servicioJugadores = servicioJugadores;
            _servicioUsuarios = servicioUsuarios;
            _servicioTramas = servicioTramas;
            _servicioAsignaciones = servicioAsignaciones;
            _servicioPostPartidas = servicioPostPartidas;
            _userManager = userManager;
        }

        // GET: SinPersonaje   
        public IActionResult SinPersonaje()
        {
            return View();
        }


        // GET: MiPersonaje        
        public async Task<IActionResult> MiPersonaje()
        {
            ApplicationUser usuario = await _userManager.GetUserAsync(User);
            Personaje personaje = await _servicioJugadores.GetMiPersonaje(usuario.Id);
            if (personaje == null)
            {
                return RedirectToAction("SinPersonaje");
            }
            return View(personaje);            
        }

        // GET: MisTramas
        public async Task<IActionResult> MisTramas()
        {
            ApplicationUser usuario = await _userManager.GetUserAsync(User);
            Personaje personaje = await _servicioJugadores.GetMisTramas(usuario.Id);
            if (personaje == null)
            {
                return RedirectToAction("SinPersonaje");
            }
            return View(personaje);
        }

        // GET: MisTramas
        public async Task<IActionResult> Asignaciones()
        {
            ApplicationUser usuario = await _userManager.GetUserAsync(User);
            Asignacion asignacion = await _servicioAsignaciones.GetAsignacion(usuario.Id);
            return View(asignacion);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Asignaciones(Asignacion asignacion)
        {
            ApplicationUser usuario = await _userManager.GetUserAsync(User);
            if (ModelState.IsValid)
            {
                _servicioAsignaciones.Actualizar(asignacion);
                await _servicioAsignaciones.ConfirmarCambios();
                ViewBag.MensajeExito = $"Asignaciones guardadas";
                asignacion = await _servicioAsignaciones.GetAsignacion(usuario.Id);
                return View(asignacion);
            }
            ViewBag.MensajeError = $"Uppss... parece que tenemos algún problemilla";
            asignacion = await _servicioAsignaciones.GetAsignacion(usuario.Id);
            return View(asignacion);
        }

        public async Task<IActionResult> FormularioPostPartida()
        {
            ApplicationUser usuario = await _userManager.GetUserAsync(User);
            FormularioPostPartida formularioPostPartida = await _servicioJugadores.GetFormularioPostPartida(usuario.Id);
            if (formularioPostPartida == null)
            {
                int postPartidaActualId = await _servicioPostPartidas.GetPostPartidaActualId();
                formularioPostPartida = await _servicioJugadores.NuevoFormularioPostPartida(usuario.Id, postPartidaActualId);
                _servicioJugadores.IncluirFormularioPostPartida(formularioPostPartida);
                await _servicioJugadores.ConfirmarCambios();
            }
            return View(formularioPostPartida);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FormularioPostPartida(FormularioPostPartida formularioPostPartida )
        {
            if (ModelState.IsValid)
            {
                _servicioJugadores.Actualizar(formularioPostPartida);
                await _servicioJugadores.ConfirmarCambios();
                ViewBag.MensajeExito = $"Formulario guardado";                
                return View(formularioPostPartida);
            }
            ViewBag.MensajeError = $"Upps, parece que tenemos algún problemilla";
            return View(formularioPostPartida);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnviarFormularioPostPartida(FormularioPostPartida formularioPostPartida)
        {            
            if (ModelState.IsValid)
            {
                await _servicioJugadores.EnviarFormularioPostPartida(formularioPostPartida);                
                ViewBag.MensajeExito = $"Formulario enviado";
                return View("FormularioPostPartida", formularioPostPartida);
            }
            ViewBag.MensajeError = $"Upps, parece que tenemos algún problemilla";
            return View("FormularioPostPartida", formularioPostPartida);
        }

        //GET: DetalleTrama/2
        public async Task<IActionResult> DetalleTrama(int? personajeId, int? tramaId)
        {
            if (personajeId == null || tramaId == null)
            {
                return NotFound();
            }

            Trama trama = await _servicioTramas.GetTramaConPasatrama(personajeId.Value, tramaId.Value);

            return View(trama);
        }
    }
}
