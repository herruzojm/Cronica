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
            string jugadorId = User.GetUserId();
            Personaje personaje = await _repositorioPersonajes.GetMiPersonaje(jugadorId);
            if (personaje == null)
            {
                //todo mostrar error de personaje no encontrado y enviar notificacion a los narradores
            }            
            return View(personaje);
        }

        // GET: Personajes/Create
        public async Task<IActionResult> Create()
        {
            Personaje personaje = await _repositorioPersonajes.GetNuevoPersonaje();

            ViewBag.Jugadores = _repositorioUsuarios.GetUsuarios().Select(u => new SelectListItem
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

            ViewBag.Jugadores = _repositorioUsuarios.GetUsuarios().Select(u => new SelectListItem
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
