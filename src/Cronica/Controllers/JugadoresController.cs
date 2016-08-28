﻿using Cronica.Modelos.Models;
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
using Cronica.Modelos.ViewModels.Mensajeria;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        private IServicioEntrePartidas _servicioEntrePartidas;
        private IServicioMensajeria _servicioMensajeria;
        private IServicioPersonajes _servicioPersonajes;

        public JugadoresController(IServicioJugadores servicioJugadores, IServicioUsuarios servicioUsuarios,
                                    IServicioTramas servicioTramas, IServicioAsignaciones servicioAsignaciones,
                                    IServicioEntrePartidas servicioPostPartidas, UserManager<ApplicationUser> userManager,
                                    IServicioMensajeria servicioMensajeria, IServicioPersonajes servicioPersonajes)
        {
            _servicioJugadores = servicioJugadores;
            _servicioUsuarios = servicioUsuarios;
            _servicioTramas = servicioTramas;
            _servicioAsignaciones = servicioAsignaciones;
            _servicioEntrePartidas = servicioPostPartidas;
            _userManager = userManager;
            _servicioMensajeria = servicioMensajeria;
            _servicioPersonajes = servicioPersonajes;
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
            VistaTramas vistaTramas = await _servicioJugadores.GetMisTramas(usuario.Id);
            if (vistaTramas == null)
            {
                return RedirectToAction("SinPersonaje");
            }
            return View(vistaTramas);
        }

        // GET: MisTramasCerradas
        public async Task<IActionResult> MisTramasCerradas()
        {
            ApplicationUser usuario = await _userManager.GetUserAsync(User);
            VistaTramas vistaTramas = await _servicioJugadores.GetMisTramasCerradas(usuario.Id);
            if (vistaTramas == null)
            {
                return RedirectToAction("SinPersonaje");
            }
            return View(vistaTramas);
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
                int postPartidaActualId = await _servicioEntrePartidas.GetEntrePartidaActualId();
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

            Trama trama = await _servicioTramas.GetTramaConInterludio(personajeId.Value, tramaId.Value);

            return View(trama);
        }

        public async Task<IActionResult> VerMensaje(int id)
        {
            ApplicationUser usuario = await _servicioUsuarios.GetUser(User);
            VistaMensaje mensaje = await _servicioMensajeria.GetMensaje(id, usuario);
            if (mensaje != null)
            {
                return View(mensaje);
            }
            else
            {
                return RedirectToAction("AccessDenied", "Account");
            }
        }

        public async Task<IActionResult> MisRecibidos()
        {
            ApplicationUser usuario = await _userManager.GetUserAsync(User);
            int personajeId = _servicioJugadores.GetPersonajeId(usuario.Id);
            return View(await _servicioMensajeria.GetMensajesRecibidos(personajeId));
        }

        public async Task<IActionResult> MisEnviados()
        {
            ApplicationUser usuario = await _userManager.GetUserAsync(User);
            int personajeId = _servicioJugadores.GetPersonajeId(usuario.Id);
            return View(await _servicioMensajeria.GetMensajesEnviados(personajeId));
        }

        public async Task<IActionResult> NuevoMensaje()
        {
            SelectList personajes = new SelectList(await _servicioPersonajes.GetEnumeradoPersonajes(), "Id", "Descripcion");
            personajes.Append(new SelectListItem() { Value = "", Text = "" });
            ViewBag.Personajes = personajes;
            ApplicationUser usuario = await _userManager.GetUserAsync(User);
            int personajeId = _servicioJugadores.GetPersonajeId(usuario.Id);
            ViewBag.PuedeHacerEnvioAnonimo = _servicioPersonajes.PuedeHacerEnvioAnonimo(personajeId);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NuevoMensaje(Mensaje mensaje, List<string> Para, List<string> CopiaOculta)
        {
            if (ModelState.IsValid)
            {
                if (Para.Count() > 0 || CopiaOculta.Count() > 0)
                {                    
                    ApplicationUser usuario = await _userManager.GetUserAsync(User);                    
                    mensaje.RemitenteId = _servicioJugadores.GetPersonajeId(usuario.Id);
                    if (!mensaje.EsAnonimo || (mensaje.EsAnonimo && _servicioPersonajes.PuedeHacerEnvioAnonimo(mensaje.RemitenteId)))
                    {
                        if (await _servicioMensajeria.EnviarMensaje(mensaje, Para, CopiaOculta))
                        {
                            ViewBag.MensajeExito = "Mensaje enviado";
                            _servicioMensajeria.EnviarEmails(Para, CopiaOculta); //todo enviar de forma asincrona
                            return View();
                        }
                    }
                    else
                    {
                        ViewBag.MensajeError = $"Uppss... esto es delicado. Parece que estás intentando mandar el mensaje como anónimo pero tu personaje no tiene las habilidades para ello";
                    }
                }
                else
                {
                    ViewBag.MensajeError = $"Iiiioooo... sipote... selecciona a alguien pa' mandarle el mensaje, ¿no?";
                }
            }
            else
            {
                ViewBag.MensajeError = $"Uppss... parece que los datos no son válidos";
            }
            SelectList personajes = new SelectList(await _servicioPersonajes.GetEnumeradoPersonajes(), "Id", "Descripcion");
            ViewBag.Personajes = personajes;
            return View(mensaje);
        }
    }
}
