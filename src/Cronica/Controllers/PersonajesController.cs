using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Cronica.Models;
using Cronica.ViewModels.Personaje;
using Cronica.Modelos.LogicaPersonajes;
using Microsoft.AspNet.Authorization;

namespace Cronica.Controllers
{
    [Authorize]
    public class PersonajesController : Controller
    {
        private CronicaDbContext _context;
        private LogicaPersonajes _logicaPersonajes;

        public PersonajesController(CronicaDbContext context, LogicaPersonajes logicaPersonajes)
        {
            _context = context;
            _logicaPersonajes = logicaPersonajes;
        }

        // GET: Personajes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Personajes.Include(p => p.Jugador).ToListAsync());
        }

        // GET: Personajes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            
            Personaje personaje = await _logicaPersonajes.GetPersonaje(id.Value);
            if (personaje == null)
            {
                return HttpNotFound();
            }            
            return View(personaje);
        }

        // GET: Personajes/Create
        public async Task<IActionResult> Create()
        {
            ViewData["JugadorId"] = new SelectList(_context.Users, "Id", "Jugador");
            ViewBag.Jugadores = _context.Users.Select(u => new SelectListItem
            {
                Value = u.Id,
                Text = u.UserName
            }).ToList();
            
            Personaje personaje = await _logicaPersonajes.GetNuevoPersonaje();            
            return View(personaje);
        }

        // POST: Personajes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Personaje personaje)
        {
            if (ModelState.IsValid)
            {
                _context.Personajes.Add(personaje);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["JugadorId"] = new SelectList(_context.Users, "Id", "Jugador", personaje.JugadorId);
            return View(personaje);
        }

        // GET: Personajes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            
            Personaje personaje = await _logicaPersonajes.GetPersonaje(id.Value);            
            ViewData["JugadorId"] = new SelectList(_context.Users, "Id", "Jugador", personaje.JugadorId);
            if (personaje == null)
            {
                return HttpNotFound();
            }
            ViewBag.Jugadores = _context.Users.Select(u => new SelectListItem
            {
                Value = u.Id,
                Text = u.UserName
            }).ToList().AsEnumerable();
            return View(personaje);
        }

        // POST: Personajes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Personaje personaje)
        {
            if (ModelState.IsValid)
            {
                _context.Update(personaje);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["JugadorId"] = new SelectList(_context.Users, "Id", "Jugador", personaje.JugadorId);
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

            Personaje personaje = await _context.Personajes.SingleAsync(m => m.PersonajeId == id);
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
            Personaje personaje = await _context.Personajes.SingleAsync(m => m.PersonajeId == id);
            _context.Personajes.Remove(personaje);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
