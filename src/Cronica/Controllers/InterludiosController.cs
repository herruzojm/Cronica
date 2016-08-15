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
        private IServicioInterludios _servicioInterludios;

        public InterludiosController(IServicioInterludios servicioInterludios)
        {
            _servicioInterludios = servicioInterludios;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _servicioInterludios.GetInterludios());
        }

        public async Task<IActionResult> ResolverInterludio(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Interludio interludio = await _servicioInterludios.GetInterludio(id.Value);
            if (interludio == null)
            {
                return NotFound();
            }

            return View(interludio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResolverInterludio(Interludio interludio)
        {     
            if (ModelState.IsValid)
            {
                interludio = await _servicioInterludios.GetInterludio(interludio.InterludioId);

                return AbrirEntrePartida(interludio.EntrePartidaId);
            }
            return View(interludio);
        }

        public async Task<IActionResult> Create(int id)
        {
            Interludio interludio = await _servicioInterludios.GetNuevoInterludio();
            interludio.EntrePartidaId = id;
            interludio.FechaPrevista = DateTime.Now.Date;
            return View(interludio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Interludio interludio)
        {
            if (ModelState.IsValid)
            {
                _servicioInterludios.IncluirInterludio(interludio);
                await _servicioInterludios.ConfirmarCambios();
                return AbrirEntrePartida(interludio.EntrePartidaId);
            }
            return View(interludio);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Interludio interludio = await _servicioInterludios.GetInterludio(id.Value);
            if (interludio == null)
            {
                return NotFound();
            }
            return View(interludio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Interludio interludio)
        {
            if (ModelState.IsValid)
            {
                _servicioInterludios.Actualizar(interludio);
                await _servicioInterludios.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(interludio);
        }

        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Interludio interludio = await _servicioInterludios.GetInterludio(id.Value);
            if (interludio == null)
            {
                return NotFound();
            }

            return View(interludio);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Interludio interludio = await _servicioInterludios.GetInterludio(id);
            _servicioInterludios.Eliminar(interludio);
            await _servicioInterludios.ConfirmarCambios();
            return RedirectToAction("Index");
        }


    }
}
