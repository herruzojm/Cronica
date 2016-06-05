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

namespace Cronica.Controllers
{
    [Authorize(Policy = "Jugador")]
    public class JugadoresController : RutasController
    {
        
        private IServicioJugadores _servicioJugadores;
        private IServicioUsuarios _servicioUsuarios;
        private IServicioTramas _servicioTramas;
        private readonly UserManager<ApplicationUser> _userManager;

        public JugadoresController(IServicioJugadores servicioJugadores, IServicioUsuarios servicioUsuarios,
                                    IServicioTramas servicioTramas, UserManager<ApplicationUser> userManager)
        {
            _servicioJugadores = servicioJugadores;
            _servicioUsuarios = servicioUsuarios;
            _servicioTramas = servicioTramas;
            _userManager = userManager;
        }

        // GET: MiPersonaje        
        public async Task<IActionResult> MiPersonaje()
        {
            ApplicationUser usuario = await _userManager.GetUserAsync(User);
            if (usuario.Cuenta == TipoCuenta.Jugador)
            {
                Personaje personaje = await _servicioJugadores.GetMiPersonaje(usuario.Id);
                if (personaje == null)
                {
                    //todo mostrar error de personaje no encontrado y enviar notificacion a los narradores
                }
                return View(personaje);
            }
            else
            {
                return RedirectToAction("Index", "Personajes");
            }
        }

        // GET: MisTramas
        public async Task<IActionResult> MisTramas()
        {
            ApplicationUser usuario = await _userManager.GetUserAsync(User);
            if (usuario.Cuenta == TipoCuenta.Jugador)
            {
                Personaje personaje = await _servicioJugadores.GetMisTramas(usuario.Id);
                if (personaje == null)
                {
                    //todo mostrar error de personaje no encontrado y enviar notificacion a los narradores
                }
                return View(personaje);
            }
            else
            {
                return RedirectToAction("Index", "Personajes");
            }
        }

        // GET: MisTramas
        public async Task<IActionResult> Asignaciones()
        {
            return View();
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
