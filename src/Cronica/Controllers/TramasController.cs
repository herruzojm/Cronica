using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Modelos.Repositorios;
using System.Collections.Generic;

namespace Cronica.Controllers
{
    public class TramasController : RutasController
    {
        private IRepositorioTramas _repositorioTramas;
        private IRepositorioPersonajes _repositorioPersonajes;
        private IRepositorioPlantillasTrama _repositorioPlantillasTrama;

        public TramasController(IRepositorioTramas repositorioTramas, 
            IRepositorioPersonajes repositorioPersonajes,
            IRepositorioPlantillasTrama repositorioPlantillasTrama)
        {
            _repositorioTramas = repositorioTramas;
            _repositorioPersonajes = repositorioPersonajes;
            _repositorioPlantillasTrama = repositorioPlantillasTrama;
        }

        // GET: TramasActivas
        public async Task<IActionResult> Index()
        {
            return View(await _repositorioTramas.GetTramas());
        }

        // GET: TramasActivas
        //public async Task<IActionResult> Index(int personajeId)
        //{
        //    return View(await _repositorioTramas.GetTramasPersonaje(personajeId));
        //}

        // GET: TramasActivas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Trama trama = await _repositorioTramas.GetTrama(id.Value);
            if (trama == null)
            {
                return HttpNotFound();
            }

            return View(trama);
        }

        // GET: TramasActivas/Create
        public async Task<IActionResult> Create(int id)
        {            
            Trama nuevaTrama = await _repositorioTramas.GetNuevaTrama(null);
            nuevaTrama.PersonajeId = id;
            ViewBag.Personaje = _repositorioPersonajes.GetPersonaje(id).Result;
            List<SelectListItem> plantillas = new List<SelectListItem>();
            plantillas.Add(new SelectListItem() { Value = "", Text = "" });
            plantillas.AddRange(_repositorioPlantillasTrama.GetPlantillasTrama().Result
                .Select(p => new SelectListItem
                {
                    Value = p.PlantillaTramaId.ToString(),
                    Text = p.Nombre
                }).ToList());
            ViewBag.Plantillas = plantillas;
            return View(nuevaTrama);
        }

        // POST: TramasActivas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Trama trama)
        {
            if (ModelState.IsValid)
            {
                _repositorioTramas.IncluirTrama(trama);
                await _repositorioTramas.ConfirmarCambios();
                return AbrirPersonaje(trama.PersonajeId);
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

            Trama trama = await _repositorioTramas.GetTrama(id.Value);
            if (trama == null)
            {
                return HttpNotFound();
            }
            ViewBag.Personaje = _repositorioPersonajes.GetPersonaje(trama.PersonajeId).Result;
            List<SelectListItem> plantillas = new List<SelectListItem>();
            plantillas.Add(new SelectListItem() { Value = "", Text = "" });
            plantillas.AddRange(_repositorioPlantillasTrama.GetPlantillasTrama().Result
                .Select(p => new SelectListItem
                {
                    Value = p.PlantillaTramaId.ToString(),
                    Text = p.Nombre
                }).ToList());
            ViewBag.Plantillas = plantillas;
            return View(trama);
        }

        // POST: TramasActivas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Trama trama)
        {
            if (ModelState.IsValid)
            {
                _repositorioTramas.ActualizarTrama(trama);
                await _repositorioTramas.ConfirmarCambios();
                return AbrirPersonaje(trama.PersonajeId);
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

            Trama trama = await _repositorioTramas.GetTrama(id.Value);
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
            Trama trama = await _repositorioTramas.GetTrama(id);
            _repositorioTramas.EliminarTrama(trama);
            await _repositorioTramas.ConfirmarCambios();
            return RedirectToAction("Index");
        }
    }
}