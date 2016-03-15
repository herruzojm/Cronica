using Cronica.Modelos.Repositorios.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System;
using Cronica.Modelos.Models;

namespace Cronica.Controllers
{
    [Authorize]
    public class PersonajesController : RutasController
    {
        private IRepositorioPersonajes _repositorioPersonajes;
        private IRepositorioUsuarios _repositorioUsuarios;

        public PersonajesController(IRepositorioPersonajes repositorioPersonajes, IRepositorioUsuarios repositorioUsuarios)
        {
            _repositorioPersonajes = repositorioPersonajes;
            _repositorioUsuarios = repositorioUsuarios;
        }

        // GET: Personajes
        public async Task<IActionResult> Index()
        {
            return View(await _repositorioPersonajes.GetPersonajes());
        }

        // GET: PersonajesJugadores
        public async Task<IActionResult> PersonajesJugadores()
        {
            return View("Index", await _repositorioPersonajes.GetPersonajesJugadores());
        }

        // GET: PersonajesJugadores
        public async Task<IActionResult> PNJs()
        {
            return View("Index", await _repositorioPersonajes.GetPNJs());
        }

        // GET: MiPersonaje
        public async Task<IActionResult> MiPersonaje()
        {
            string userId = User.GetUserId();
            ApplicationUser usuario = await _repositorioUsuarios.GetUsuarioById(userId);
            if (usuario.Cuenta == TipoCuenta.Jugador)
            {
                Personaje personaje = await _repositorioPersonajes.GetMiPersonaje(userId);
                if (personaje == null)
                {
                    //todo mostrar error de personaje no encontrado y enviar notificacion a los narradores
                }
                return View(personaje);                
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // GET: MiPersonaje
        public async Task<IActionResult> MisTramas()
        {
            return View();
        }

        // GET: Personajes/Create
        public async Task<IActionResult> Create()
        {
            Personaje personaje = await _repositorioPersonajes.GetNuevoPersonaje();

            var jugadores = await _repositorioUsuarios.GetUsuarios();

            ViewBag.Jugadores = jugadores.Select(u => new SelectListItem
            {
                Value = u.Id,
                Text = u.UserName
            }).ToList();
                                  
            return View(personaje);
        }

        // POST: Personajes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Personaje personaje)
        {
            if (ModelState.IsValid)
            {
                _repositorioPersonajes.IncluirPersonaje(personaje);
                await _repositorioPersonajes.ConfirmarCambios();                
                return RedirectToAction("Index");
            }
            return View(personaje);
        }

        // GET: Personajes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            
            Personaje personaje = await _repositorioPersonajes.GetPersonajeCompleto(id.Value);            
            if (personaje == null)
            {
                return HttpNotFound();
            }

            var jugadores = await _repositorioUsuarios.GetUsuarios();

            ViewBag.Jugadores = jugadores.Select(u => new SelectListItem
            {
                Value = u.Id,
                Text = u.UserName
            }).ToList();

            return View(personaje);
        }

        // POST: Personajes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Personaje personaje)
        {
            if (ModelState.IsValid)
            {
                _repositorioPersonajes.Actualizar(personaje);
                await _repositorioPersonajes.ConfirmarCambios();
                return RedirectToAction("Index");                
            }
            return View(personaje);
        }

        // GET: Personajes/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Personaje personaje = await _repositorioPersonajes.GetPersonajeCompleto(id.Value);
            if (personaje == null)
            {
                return HttpNotFound();
            }

            return View(personaje);
        }

        // POST: Personajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Personaje personaje = await _repositorioPersonajes.GetPersonajeCompleto(id);            
            _repositorioPersonajes.Eliminar(personaje);
            await _repositorioPersonajes.ConfirmarCambios();
            return RedirectToAction("Index");
        }

    }
}
