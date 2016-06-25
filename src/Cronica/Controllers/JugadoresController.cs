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

        public JugadoresController(IServicioJugadores servicioJugadores, IServicioUsuarios servicioUsuarios,
                                    IServicioTramas servicioTramas, IServicioAsignaciones servicioAsignaciones,
                                    UserManager<ApplicationUser> userManager)
        {
            _servicioJugadores = servicioJugadores;
            _servicioUsuarios = servicioUsuarios;
            _servicioTramas = servicioTramas;
            _servicioAsignaciones = servicioAsignaciones;
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
            ApplicationUser usuario = await _userManager.GetUserAsync(User);
            if (usuario.Cuenta == TipoCuenta.Jugador)
            {
                Asignacion asignacion = await _servicioAsignaciones.GetAsignacion(usuario.Id, 2);                
                return View(asignacion);
            }
            else
            {
                return RedirectToAction("Index", "Personajes");
            }
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
                asignacion = await _servicioAsignaciones.GetAsignacion(usuario.Id, 2);
                return View(asignacion);
            }
            ViewBag.MensajeError = $"Uppss... parece que tenemos algún problemilla";
            asignacion = await _servicioAsignaciones.GetAsignacion(usuario.Id, 2);
            return View(asignacion);
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
