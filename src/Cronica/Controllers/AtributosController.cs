using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Cronica.ViewModels.Personaje;
using Cronica.Models;

namespace Cronica.Controllers
{
    public class AtributosController : Controller
    {
        private CronicaDbContext _context;

        public AtributosController(CronicaDbContext context)
        {
            _context = context;
        }

        // GET: Atributo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Atributos.ToListAsync());
        }

        // GET: Atributo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Atributo atributoViewModel = await _context.Atributos.SingleAsync(m => m.Id == id);
            if (atributoViewModel == null)
            {
                return HttpNotFound();
            }

            return View(atributoViewModel);
        }

        // GET: Atributo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Atributo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Atributo atributo)
        {
            if (ModelState.IsValid)
            {
                _context.Atributos.Add(atributo);
                await _context.SaveChangesAsync();
                IncluirAtributoEnPersonajes(atributo);
                return RedirectToAction("Index");
            }
            return View(atributo);
        }

        // GET: Atributo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Atributo atributoViewModel = await _context.Atributos.SingleAsync(m => m.Id == id);
            if (atributoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(atributoViewModel);
        }

        // POST: Atributo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Atributo atributoViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Update(atributoViewModel);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(atributoViewModel);
        }

        private void IncluirAtributoEnPersonajes(Atributo nuevoAtributo)
        {
            var personajes = _context.Personajes.ToList<Personaje>();
            personajes.ForEach(p => p.Atributos.Add(
                    new AtributoPersonaje() { AtributoId = nuevoAtributo.Id, PersonajeId = p.Id, Valor = 0 }
                ));
            _context.SaveChanges();
        }

        //// GET: Atributo/Delete/5
        //[ActionName("Delete")]
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    Atributo atributoViewModel = await _context.Atributos.SingleAsync(m => m.Id == id);
        //    if (atributoViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(atributoViewModel);
        //}

        //// POST: Atributo/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    Atributo atributoViewModel = await _context.Atributos.SingleAsync(m => m.Id == id);
        //    _context.Atributos.Remove(atributoViewModel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}
    }
}