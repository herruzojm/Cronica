using Cronica.Servicios.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Servicios;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Authorization;

namespace Cronica.Controllers
{
    [Authorize(Policy = "Narrador")]
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
        
        public IActionResult DetalleTrama(int plantillaTramaId)
        {
            return ViewComponent(nameof(DetalleTrama), new { plantillaTramaId = plantillaTramaId });
        }

        public IActionResult ParticipantesTrama(int tramaId, TipoTrama tipoTrama)
        {
            return ViewComponent(nameof(ParticipantesTrama), new { tramaId = tramaId, tipoTrama = tipoTrama });
        }

        // GET: TramasActivas/Create
        public async Task<IActionResult> Create(int? personajeId, int? plantillaTramaId)
        {                        
            Trama nuevaTrama = await _servicioTramas.GetNuevaTrama(plantillaTramaId);

            if (personajeId.HasValue)
            {
                ParticipantesTrama participante = new ParticipantesTrama();
                participante.PersonajeId = personajeId.Value;
                nuevaTrama.Participantes.Add(participante);
                ViewBag.Personaje = await _servicioPersonajes.GetPersonaje(personajeId.Value);
            }
            
            
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
        public async Task<IActionResult> Create(Trama trama, VistaParticipantesTramas vistaParticipantes)
        {
            if (ModelState.IsValid)
            {
                await _servicioTramas.CrearTrama(trama, vistaParticipantes);                
                return RedirectToAction("Edit", new { id = trama.TramaId });
                
            }
            return View(trama);
        }

        private async Task<Trama> DevolverVistaEdicionTrama(int tramaId)
        {
            List<SelectListItem> plantillas = new List<SelectListItem>();
            plantillas.Add(new SelectListItem() { Value = "", Text = "" });
            plantillas.AddRange(_servicioPlantillasTrama.GetPlantillasTrama().Result
                .Select(p => new SelectListItem
                {
                    Value = p.PlantillaTramaId.ToString(),
                    Text = p.Nombre
                }).ToList());
            ViewBag.Plantillas = plantillas;

            Trama trama = await _servicioTramas.GetTrama(tramaId);
            return trama;
        }

        // GET: TramasActivas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //todo vincular a lista de personajes
            if (id == null)
            {
                return NotFound();
            }

            Trama trama = await DevolverVistaEdicionTrama(id.Value);
            if (trama == null)
            {
                return NotFound();
            }            

            return View(trama);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Trama trama, VistaParticipantesTramas vistaParticipantes)
        {
            if (ModelState.IsValid)
            {
                await _servicioTramas.ActualizarTrama(trama, vistaParticipantes);
                ViewBag.MensajeExito = $"Trama guardada";
                return View(await DevolverVistaEdicionTrama(trama.TramaId));
            }
            return RedirectToAction("Edit", new { id = trama.TramaId });
        }

        // GET: TramasActivas/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trama trama = await _servicioTramas.GetTrama(id.Value);
            if (trama == null)
            {
                return NotFound();
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
