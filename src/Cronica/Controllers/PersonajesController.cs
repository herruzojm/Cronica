using Cronica.Servicios.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Microsoft.AspNetCore.Authorization;

namespace Cronica.Controllers
{

    [Authorize(Policy = "Narrador")]
    public class PersonajesController : RutasController
    {
        private IServicioPersonajes _servicioPersonajes;
        private IServicioUsuarios _servicioUsuarios;

        public PersonajesController(IServicioPersonajes servicioPersonajes, IServicioUsuarios servicioUsuarios)
        {
            _servicioPersonajes = servicioPersonajes;
            _servicioUsuarios = servicioUsuarios;
        }

        // GET: Personajes
        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Lista Completa de Personajes";
            return View(await _servicioPersonajes.GetPersonajes());
        }

        // GET: PersonajesJugadores        
        public async Task<IActionResult> PersonajesJugadores()
        {
            ViewData["Title"] = "Personajes Jugadores";
            return View("Index", await _servicioPersonajes.GetPersonajesJugadores());
        }

        // GET: PNJs
        public async Task<IActionResult> PNJs()
        {
            ViewData["Title"] = "PNJs";
            return View("Index", await _servicioPersonajes.GetPNJs());
        }

        // GET: Personajes/Create
        public async Task<IActionResult> Create()
        {
            Personaje personaje = await _servicioPersonajes.GetNuevoPersonaje();

            var jugadores = await _servicioUsuarios.GetUsuarios();

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
                _servicioPersonajes.IncluirPersonaje(personaje);
                await _servicioPersonajes.ConfirmarCambios();                
                return RedirectToAction("Edit", new { id = personaje.PersonajeId });
            }
            return View(personaje);
        }

        // GET: Personajes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            Personaje personaje = await _servicioPersonajes.GetPersonajeCompleto(id.Value);            
            if (personaje == null)
            {
                return NotFound();
            }

            var jugadores = await _servicioUsuarios.GetUsuarios();

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
                _servicioPersonajes.Actualizar(personaje);
                await _servicioPersonajes.ConfirmarCambios();
                ViewBag.MensajeExito = $"Personaje guardado";
                personaje = await _servicioPersonajes.GetPersonajeCompleto(personaje.PersonajeId);
                return View(personaje);
            }
            return View(personaje);
        }

        // GET: Personajes/Delete/5
        [Authorize(Policy = "Administrador")]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Personaje personaje = await _servicioPersonajes.GetPersonajeCompleto(id.Value);
            if (personaje == null)
            {
                return NotFound();
            }

            return View(personaje);
        }

        // POST: Personajes/Delete/5
        [Authorize(Policy = "Administrador")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Personaje personaje = await _servicioPersonajes.GetPersonajeCompleto(id);            
            _servicioPersonajes.Eliminar(personaje);
            await _servicioPersonajes.ConfirmarCambios();
            return RedirectToAction("Index");
        }

    }
}
