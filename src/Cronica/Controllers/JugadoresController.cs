using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
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

        public JugadoresController(IServicioJugadores servicioJugadores, IServicioUsuarios servicioUsuarios,
                                    IServicioTramas servicioTramas)
        {
            _servicioJugadores = servicioJugadores;
            _servicioUsuarios = servicioUsuarios;
            _servicioTramas = servicioTramas;
        }

        // GET: MiPersonaje        
        public async Task<IActionResult> MiPersonaje()
        {
            string userId = User.GetUserId();
            ApplicationUser usuario = await _servicioUsuarios.GetUsuarioById(userId);
            if (usuario.Cuenta == TipoCuenta.Jugador)
            {
                Personaje personaje = await _servicioJugadores.GetMiPersonaje(userId);
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
            string userId = User.GetUserId();
            ApplicationUser usuario = await _servicioUsuarios.GetUsuarioById(userId);
            if (usuario.Cuenta == TipoCuenta.Jugador)
            {
                Personaje personaje = await _servicioJugadores.GetMisTramas(userId);
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
                return HttpNotFound();
            }

            Trama trama = await _servicioTramas.GetTramaConPasatrama(personajeId.Value, tramaId.Value);

            return View(trama);
        }
    }
}
