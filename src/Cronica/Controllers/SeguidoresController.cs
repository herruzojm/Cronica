using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Servicios.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Rendering;

namespace Cronica.Controllers
{
    
    public class SeguidoresController : RutasController
    {
        private IServicioSeguidor _servicioSeguidores;

        public SeguidoresController(IServicioSeguidor servicioSeguidores)
        {
            _servicioSeguidores = servicioSeguidores;
        }

        // GET:Personajes/Edit/5/Ligar
        [Route("Personajes/Edit/{personajeId:int}/Ligar", Name = "Ligar")]
        public async Task<IActionResult> Ligar(int personajeId)
        {
            PersonaTrasfondo nuevoSeguidor = new PersonaTrasfondo();
            nuevoSeguidor.PersonajeJugadorId = personajeId;
            ViewBag.Seguidores = _servicioSeguidores.GetSeguidoresPotenciales(personajeId).Result.Select(seguidor => new SelectListItem
            {
                Value = seguidor.SeguidorId.ToString(),
                Text = seguidor.Nombre
            }).ToList();

            return View(nuevoSeguidor);
        }

        // POST: Personajes/Edit/5/Ligar
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Personajes/Edit/{personajeId:int}/Ligar", Name = "Ligar")]
        public async Task<IActionResult> Ligar(PersonaTrasfondo seguidor)
        {
            if (ModelState.IsValid)
            {
                _servicioSeguidores.GuardarSeguidor(seguidor);
                await _servicioSeguidores.ConfirmarCambios();
                return AbrirPersonaje(seguidor.PersonajeJugadorId);
            }
            return View(seguidor);
        }

        // GET: Personajes/Edit/5/Desligar/3
        [ActionName("Desligar")]
        [Route("Personajes/Edit/{personajeId:int}/Desligar/{seguidorId:int}", Name = "Desligar")]
        public async Task<IActionResult> Desligar(int personajeId, int seguidorId)
        {
            
            PersonaTrasfondo seguidor = await _servicioSeguidores.GetSeguidor(personajeId, seguidorId); ;
            if (seguidor == null)
            {
                return HttpNotFound();
            }

            return View(seguidor);
        }

        // POST: Personajes/Edit/5/Desligar/3        
        [HttpPost, ActionName("Desligar")]
        [ValidateAntiForgeryToken]
        [Route("Personajes/Edit/{personajeId:int}/Desligar/{seguidorId:int}", Name = "Desligar")]
        public async Task<IActionResult> DesligarConfirmed(PersonaTrasfondo seguidor)
        {
            int id = seguidor.PersonajeJugadorId;
            _servicioSeguidores.Eliminar(seguidor);
            await _servicioSeguidores.ConfirmarCambios();
            return AbrirPersonaje(id);
        }
    }
}