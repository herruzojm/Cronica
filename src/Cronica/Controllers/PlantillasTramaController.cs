using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Cronica.Modelos.ViewModels.Trama;
using Cronica.Models;
using Cronica.Modelos.LogicaPersonajes;

namespace Cronica.Controllers
{
    public class PlantillasTramaController : Controller
    {
        private CronicaDbContext _context;
        private LogicaPlantillasTrama _logicaPlantillasTrama;

        public PlantillasTramaController(CronicaDbContext context, LogicaPlantillasTrama logicaPlantillasTrama)
        {
            _context = context;
            _logicaPlantillasTrama = logicaPlantillasTrama;
        }

        // GET: PlantillasTrama
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlantillasTrama.ToListAsync());
        }

        // GET: PlantillasTrama/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PlantillaTrama plantillaTrama = await _logicaPlantillasTrama.GetPlantillaTrama(id.Value);
            if (plantillaTrama == null)
            {
                return HttpNotFound();
            }

            return View(plantillaTrama);
        }

        // GET: PlantillasTrama/Create
        public async Task<IActionResult> Create()
        {
            PlantillaTrama plantilla = await _logicaPlantillasTrama.GetNuevaPlantilla();
            return View(plantilla);
        }

        // POST: PlantillasTrama/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PlantillaTrama plantillaTrama)
        {
            if (ModelState.IsValid)
            {
                _context.PlantillasTrama.Add(plantillaTrama);
                await _context.SaveChangesAsync();
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

            PlantillaTrama plantillaTrama = await _logicaPlantillasTrama.GetPlantillaTrama(id.Value);
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
                _context.Update(plantillaTrama);
                await _context.SaveChangesAsync();
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

            PlantillaTrama plantillaTrama = await _context.PlantillasTrama.SingleAsync(m => m.PlantillaTramaId == id);
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
            PlantillaTrama plantillaTrama = await _context.PlantillasTrama.SingleAsync(m => m.PlantillaTramaId == id);
            _context.PlantillasTrama.Remove(plantillaTrama);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
