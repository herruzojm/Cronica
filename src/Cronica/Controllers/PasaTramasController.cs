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
    public class PasaTramasController : RutasController
    {
        private IServicioPasaTramas _servicioPasaTramas;

        public PasaTramasController(IServicioPasaTramas servicioPasaTrama)
        {
            _servicioPasaTramas = servicioPasaTrama;
        }

        // GET: PasaTramas
        public async Task<IActionResult> Index()
        {
            return View(await _servicioPasaTramas.GetPasaTramas());
        }

        // GET: PasaTramas/Details/5
        public async Task<IActionResult> ResolverPasaTrama(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PasaTrama pasaTrama = await _servicioPasaTramas.GetPasaTrama(id.Value);
            if (pasaTrama == null)
            {
                return NotFound();
            }

            return View(pasaTrama);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResolverPasaTrama(PasaTrama pasaTrama)
        {     
            if (ModelState.IsValid)
            {
                //todo: resolver pasa trama
                return AbrirPostPartida(pasaTrama.PostPartidaId);
            }
            return View(pasaTrama);
        }

        // GET: PasaTramas/Create
        public async Task<IActionResult> Create(int id)
        {
            PasaTrama pasaTrama = await _servicioPasaTramas.GetNuevoPasaTrama();
            pasaTrama.PostPartidaId = id;
            pasaTrama.FechaPrevista = DateTime.Now.Date;
            return View(pasaTrama);
        }

        // POST: PasaTramas/Create
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

        // GET: PasaTramas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PasaTrama pasaTrama = await _servicioPasaTramas.GetPasaTrama(id.Value);
            if (pasaTrama == null)
            {
                return NotFound();
            }
            return View(pasaTrama);
        }

        // POST: PasaTramas/Edit/5
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

        // GET: PasaTramas/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PasaTrama pasaTrama = await _servicioPasaTramas.GetPasaTrama(id.Value);
            if (pasaTrama == null)
            {
                return NotFound();
            }

            return View(pasaTrama);
        }

        // POST: PasaTramas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            PasaTrama pasaTrama = await _servicioPasaTramas.GetPasaTrama(id);
            _servicioPasaTramas.Eliminar(pasaTrama);
            await _servicioPasaTramas.ConfirmarCambios();
            return RedirectToAction("Index");
        }


    }
}
