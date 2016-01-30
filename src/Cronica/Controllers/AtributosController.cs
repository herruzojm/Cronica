using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Cronica.Modelos.ViewModels.GestionPersonaje;
using Cronica.Modelos.Models;
using Cronica.Modelos.Repositorios;

namespace Cronica.Controllers
{
    public class AtributosController : Controller
    {
        private IRepositorioAtributos _repositorioAtributos;

        public AtributosController(IRepositorioAtributos repositorioAtributos)
        {
            _repositorioAtributos = repositorioAtributos;
        }

        // GET: Atributo
        public async Task<IActionResult> Index()
        {
            return View(await _repositorioAtributos.GetAtributos());
        }

        // GET: Atributo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Atributo atributoViewModel = await _repositorioAtributos.GetAtributo(id.Value);
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
                await _repositorioAtributos.CrearAtributo(atributo);
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

            Atributo atributoViewModel = await _repositorioAtributos.GetAtributo(id.Value);
            if (atributoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(atributoViewModel);
        }

        // POST: Atributo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Atributo atributo)
        {
            if (ModelState.IsValid)
            {
                _repositorioAtributos.ActualizarAtributo(atributo);
                await _repositorioAtributos.ConfirmarCambios();

                return RedirectToAction("Index");
            }
            return View(atributo);
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
