using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Modelos.Models;
using Cronica.Modelos.Repositorios;

namespace Cronica.Controllers
{
    public class PlantillasTramaController : Controller
    {
        private IRepositorioPlantillasTrama _repositorioPlantillasTrama;

        public PlantillasTramaController(IRepositorioPlantillasTrama repositorioPlantillasTrama)
        {
            _repositorioPlantillasTrama = repositorioPlantillasTrama;
        }

        // GET: PlantillasTrama
        public async Task<IActionResult> Index()
        {
            return View(await _repositorioPlantillasTrama.GetPlantillasTrama());
        }

        // GET: PlantillasTrama/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PlantillaTrama plantillaTrama = await _repositorioPlantillasTrama.GetPlantillaTrama(id.Value);
            if (plantillaTrama == null)
            {
                return HttpNotFound();
            }

            return View(plantillaTrama);
        }

        // GET: PlantillasTrama/Create
        public async Task<IActionResult> Create()
        {
            PlantillaTrama plantilla = await _repositorioPlantillasTrama.GetNuevaPlantilla();
            return View(plantilla);
        }

        // POST: PlantillasTrama/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PlantillaTrama plantillaTrama)
        {
            if (ModelState.IsValid)
            {
                _repositorioPlantillasTrama.IncluirPlantillaTrama(plantillaTrama);
                await _repositorioPlantillasTrama.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(plantillaTrama);
        }

        // GET: PlantillasTrama/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PlantillaTrama plantillaTrama = await _repositorioPlantillasTrama.GetPlantillaTrama(id.Value);
            if (plantillaTrama == null)
            {
                return HttpNotFound();
            }
            return View(plantillaTrama);
        }

        // POST: PlantillasTrama/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PlantillaTrama plantillaTrama)
        {
            if (ModelState.IsValid)
            {
                _repositorioPlantillasTrama.Actualizar(plantillaTrama);
                await _repositorioPlantillasTrama.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(plantillaTrama);
        }

        // GET: PlantillasTrama/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PlantillaTrama plantillaTrama = await _repositorioPlantillasTrama.GetPlantillaTrama(id.Value);
            if (plantillaTrama == null)
            {
                return HttpNotFound();
            }

            return View(plantillaTrama);
        }

        // POST: PlantillasTrama/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            PlantillaTrama plantillaTrama = await _repositorioPlantillasTrama.GetPlantillaTrama(id);
            _repositorioPlantillasTrama.Eliminar(plantillaTrama);
            await _repositorioPlantillasTrama.ConfirmarCambios();                        
            return RedirectToAction("Index");
        }
    }
}
