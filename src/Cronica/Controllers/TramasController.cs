using Cronica.Servicios.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Servicios;
using System.Collections.Generic;

namespace Cronica.Controllers
{
    public class TramasController : RutasController
    {
        private IServicioTramas _servicioTramas;
        private IServicioPersonajes _servicioPersonajes;
        private IServicioPlantillasTrama _servicioPlantillasTrama;

        public TramasController(IServicioTramas servicioTramas, 
            IServicioPersonajes servicioPersonajes,
            IServicioPlantillasTrama servicioPlantillasTrama)
        {
            _servicioTramas = servicioTramas;
            _servicioPersonajes = servicioPersonajes;
            _servicioPlantillasTrama = servicioPlantillasTrama;
        }

        // GET: TramasActivas
        public async Task<IActionResult> Index()
        {
            return View(await _servicioTramas.GetTramas());
        }

        // GET: TramasActivas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Trama trama = await _servicioTramas.GetTrama(id.Value);
            if (trama == null)
            {
                return HttpNotFound();
            }

            return View(trama);
        }

        // GET: TramasActivas/Create
        public async Task<IActionResult> Create(int personajeId, int? plantillaTramaId)
        {            
            //todo vincular a lista de personajes
            Trama nuevaTrama = await _servicioTramas.GetNuevaTrama(plantillaTramaId);
            ParticipantesTrama participante = new ParticipantesTrama();
            participante.PersonajeId = personajeId;
            nuevaTrama.Participantes.Add(participante);
            ViewBag.Personaje = await _servicioPersonajes.GetPersonaje(personajeId);
            List<SelectListItem> plantillas = new List<SelectListItem>();
            plantillas.Add(new SelectListItem() { Value = "", Text = "" });
            plantillas.AddRange(_servicioPlantillasTrama.GetPlantillasTrama().Result
                .Select(p => new SelectListItem
                {
                    Value = p.PlantillaTramaId.ToString(),
                    Text = p.Nombre,                    
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
                _servicioTramas.IncluirTrama(trama);
                await _servicioTramas.ConfirmarCambios();
                //todo volver al personaje o a la lista de tramas
                //return AbrirPersonaje(trama.PersonajeId);
                
            }
            return View(trama);
        }

        // GET: TramasActivas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //todo vincular a lista de personajes
            if (id == null)
            {
                return HttpNotFound();
            }

            Trama trama = await _servicioTramas.GetTrama(id.Value);
            if (trama == null)
            {
                return HttpNotFound();
            }
            //todo lista participantes
            //ViewBag.Personaje = _servicioPersonajes.GetPersonaje(trama.PersonajeId).Result;
            List<SelectListItem> plantillas = new List<SelectListItem>();
            plantillas.Add(new SelectListItem() { Value = "", Text = "" });
            plantillas.AddRange(_servicioPlantillasTrama.GetPlantillasTrama().Result
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
                _servicioTramas.Actualizar(trama);
                await _servicioTramas.ConfirmarCambios();
                //todo volver al personaje o a la lista de tramas
                //return AbrirPersonaje(trama.PersonajeId);
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

            Trama trama = await _servicioTramas.GetTrama(id.Value);
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
            Trama trama = await _servicioTramas.GetTrama(id);
            _servicioTramas.Eliminar(trama);
            await _servicioTramas.ConfirmarCambios();
            return RedirectToAction("Index");
        }
    }
}
