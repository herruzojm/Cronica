using Cronica.Servicios.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.Models;
using Cronica.Servicios;
using Microsoft.AspNetCore.Authorization;

namespace Cronica.Controllers
{
    [Authorize(Policy = "Administrador")]
    public class EntrePartidasController : RutasController
    {
        private IServicioEntrePartidas _servicioEntrePartidas;

        public EntrePartidasController(IServicioEntrePartidas servicioEntrePartidas)
        {
            _servicioEntrePartidas = servicioEntrePartidas;    
        }

        public async Task<IActionResult> Index()
        {
            return View(await _servicioEntrePartidas.GetEntrePartidas());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EntrePartida entrePartida)
        {
            if (ModelState.IsValid)
            {
                _servicioEntrePartidas.IncluirEntrePartida(entrePartida);
                await _servicioEntrePartidas.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(entrePartida);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EntrePartida entrePartida = await _servicioEntrePartidas.GetEntrePartida(id.Value);
            if (entrePartida == null)
            {
                return NotFound();
            }
            return View(entrePartida);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EntrePartida entrePartida)
        {
            if (ModelState.IsValid)
            {
                EntrePartida entrePartidaOriginal = await _servicioEntrePartidas.GetEntrePartida(entrePartida.EntrePartidaId);
                entrePartidaOriginal.FechaFin = entrePartida.FechaFin;
                entrePartidaOriginal.FechaInicio = entrePartida.FechaInicio;
                _servicioEntrePartidas.Actualizar(entrePartidaOriginal);
                await _servicioEntrePartidas.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(entrePartida);
        }
    }
}
