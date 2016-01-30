using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Modelos.Repositorios;

namespace Cronica.Controllers
{
    public class TramasController : Controller
    {
        private IRepositorioTramas _repositorio;

        public TramasController(IRepositorioTramas repositorio)
        {
            _repositorio = repositorio;    
        }

        // GET: TramasActivas
        public async Task<IActionResult> Index()
        {
            return View(await _repositorio.GetTramas());
        }

        // GET: TramasActivas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Trama trama = await _repositorio.GetTrama(id.Value);
            if (trama == null)
            {
                return HttpNotFound();
            }

            return View(trama);
        }

        // GET: TramasActivas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TramasActivas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Trama trama)
        {
            if (ModelState.IsValid)
            {
                _repositorio.IncluirTrama(trama);
                await _repositorio.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(trama);
        }

        // GET: TramasActivas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Trama trama = await _repositorio.GetTrama(id.Value);
            if (trama == null)
            {
                return HttpNotFound();
            }
            return View(trama);
        }

        // POST: TramasActivas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Trama trama)
        {
            if (ModelState.IsValid)
            {
                _repositorio.ActualizarTrama(trama);
                await _repositorio.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(trama);
        }

        // GET: TramasActivas/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Trama trama = await _repositorio.GetTrama(id.Value);
            if (trama == null)
            {
                return HttpNotFound();
            }

            return View(trama);
        }

        // POST: TramasActivas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Trama trama = await _repositorio.GetTrama(id);
            _repositorio.EliminarTrama(trama);
            await _repositorio.ConfirmarCambios();
            return RedirectToAction("Index");
        }
    }
}
