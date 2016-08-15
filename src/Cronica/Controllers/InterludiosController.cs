using Cronica.Servicios.Interfaces;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Servicios;
using Microsoft.AspNetCore.Authorization;

namespace Cronica.Controllers
{
    [Authorize(Policy = "Administrador")]
    public class InterludiosController : RutasController
    {
        private IServicioInterludios _servicioPasaTramas;

        public InterludiosController(IServicioInterludios servicioPasaTrama)
        {
            _servicioPasaTramas = servicioPasaTrama;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _servicioPasaTramas.GetInterludios());
        }

        public async Task<IActionResult> ResolverInterludio(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PasaTrama pasaTrama = await _servicioPasaTramas.GetInterludio(id.Value);
            if (pasaTrama == null)
            {
                return NotFound();
            }

            return View(pasaTrama);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResolverInterludio(PasaTrama pasaTrama)
        {     
            if (ModelState.IsValid)
            {
                pasaTrama = await _servicioPasaTramas.GetInterludio(pasaTrama.PasaTramaId);

                return AbrirPostPartida(pasaTrama.PostPartidaId);
            }
            return View(pasaTrama);
        }

        public async Task<IActionResult> Create(int id)
        {
            PasaTrama pasaTrama = await _servicioPasaTramas.GetNuevoInterludio();
            pasaTrama.PostPartidaId = id;
            pasaTrama.FechaPrevista = DateTime.Now.Date;
            return View(pasaTrama);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PasaTrama pasaTrama)
        {
            if (ModelState.IsValid)
            {
                _servicioPasaTramas.IncluirPasaTrama(pasaTrama);
                await _servicioPasaTramas.ConfirmarCambios();
                return AbrirPostPartida(pasaTrama.PostPartidaId);
            }
            return View(pasaTrama);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PasaTrama pasaTrama = await _servicioPasaTramas.GetInterludio(id.Value);
            if (pasaTrama == null)
            {
                return NotFound();
            }
            return View(pasaTrama);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PasaTrama pasaTrama)
        {
            if (ModelState.IsValid)
            {
                _servicioPasaTramas.Actualizar(pasaTrama);
                await _servicioPasaTramas.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(pasaTrama);
        }

        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PasaTrama pasaTrama = await _servicioPasaTramas.GetInterludio(id.Value);
            if (pasaTrama == null)
            {
                return NotFound();
            }

            return View(pasaTrama);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            PasaTrama pasaTrama = await _servicioPasaTramas.GetInterludio(id);
            _servicioPasaTramas.Eliminar(pasaTrama);
            await _servicioPasaTramas.ConfirmarCambios();
            return RedirectToAction("Index");
        }


    }
}
