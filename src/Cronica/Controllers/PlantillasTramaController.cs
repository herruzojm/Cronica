using Cronica.Servicios.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Modelos.Models;
using Cronica.Servicios;
using Microsoft.AspNetCore.Authorization;

namespace Cronica.Controllers
{
    [Authorize(Policy = "Administrador")]
    public class PlantillasTramaController : RutasController
    {
        private IServicioPlantillasTrama _servicioPlantillasTrama;

        public PlantillasTramaController(IServicioPlantillasTrama servicioPlantillasTrama)
        {
            _servicioPlantillasTrama = servicioPlantillasTrama;
        }

        // GET: PlantillasTrama
        public async Task<IActionResult> Index()
        {
            return View(await _servicioPlantillasTrama.GetPlantillasTrama());
        }

        // GET: PlantillasTrama/Create
        public async Task<IActionResult> Create()
        {
            PlantillaTrama plantilla = await _servicioPlantillasTrama.GetNuevaPlantilla();
            return View(plantilla);
        }

        // POST: PlantillasTrama/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PlantillaTrama plantillaTrama)
        {
            if (ModelState.IsValid)
            {
                _servicioPlantillasTrama.IncluirPlantillaTrama(plantillaTrama);
                await _servicioPlantillasTrama.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(plantillaTrama);
        }

        // GET: PlantillasTrama/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PlantillaTrama plantillaTrama = await _servicioPlantillasTrama.GetPlantillaTrama(id.Value);
            if (plantillaTrama == null)
            {
                return NotFound();
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
                _servicioPlantillasTrama.Actualizar(plantillaTrama);
                await _servicioPlantillasTrama.ConfirmarCambios();
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
                return NotFound();
            }

            PlantillaTrama plantillaTrama = await _servicioPlantillasTrama.GetPlantillaTrama(id.Value);
            if (plantillaTrama == null)
            {
                return NotFound();
            }

            return View(plantillaTrama);
        }

        // POST: PlantillasTrama/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            PlantillaTrama plantillaTrama = await _servicioPlantillasTrama.GetPlantillaTrama(id);
            _servicioPlantillasTrama.Eliminar(plantillaTrama);
            await _servicioPlantillasTrama.ConfirmarCambios();                        
            return RedirectToAction("Index");
        }
    }
}
