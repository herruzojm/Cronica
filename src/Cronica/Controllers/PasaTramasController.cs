using Cronica.Modelos.Repositorios.Interfaces;
using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.Repositorios;

namespace Cronica.Controllers
{
    public class PasaTramasController : RutasController
    {
        private IRepositorioPasaTramas _repositorioPasaTramas;

        public PasaTramasController(IRepositorioPasaTramas repositorioPasaTrama)
        {
            _repositorioPasaTramas = repositorioPasaTrama;
        }

        // GET: PasaTramas
        public async Task<IActionResult> Index()
        {
            return View(await _repositorioPasaTramas.GetPasaTramas());
        }

        // GET: PasaTramas/Details/5
        public async Task<IActionResult> ResolverPasaTrama(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PasaTrama pasaTrama = await _repositorioPasaTramas.GetPasaTrama(id.Value);
            if (pasaTrama == null)
            {
                return HttpNotFound();
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
            PasaTrama pasaTrama = await _repositorioPasaTramas.GetNuevoPasaTrama();
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
                _repositorioPasaTramas.IncluirPasaTrama(pasaTrama);
                await _repositorioPasaTramas.ConfirmarCambios();
                return AbrirPostPartida(pasaTrama.PostPartidaId);
            }
            return View(pasaTrama);
        }

        // GET: PasaTramas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PasaTrama pasaTrama = await _repositorioPasaTramas.GetPasaTrama(id.Value);
            if (pasaTrama == null)
            {
                return HttpNotFound();
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
                _repositorioPasaTramas.Actualizar(pasaTrama);
                await _repositorioPasaTramas.ConfirmarCambios();
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
                return HttpNotFound();
            }

            PasaTrama pasaTrama = await _repositorioPasaTramas.GetPasaTrama(id.Value);
            if (pasaTrama == null)
            {
                return HttpNotFound();
            }

            return View(pasaTrama);
        }

        // POST: PasaTramas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            PasaTrama pasaTrama = await _repositorioPasaTramas.GetPasaTrama(id);
            _repositorioPasaTramas.Eliminar(pasaTrama);
            await _repositorioPasaTramas.ConfirmarCambios();
            return RedirectToAction("Index");
        }


    }
}
