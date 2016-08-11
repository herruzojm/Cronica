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

        // GET: PostPartidas
        public async Task<IActionResult> Index()
        {
            return View(await _servicioEntrePartidas.GetPostPartidas());
        }

        // GET: PostPartidas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PostPartidas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PostPartida postPartida)
        {
            if (ModelState.IsValid)
            {
                _servicioEntrePartidas.IncluirPostPartida(postPartida);
                await _servicioEntrePartidas.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(postPartida);
        }

        // GET: PostPartidas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PostPartida postPartida = await _servicioEntrePartidas.GetPostPartida(id.Value);
            if (postPartida == null)
            {
                return NotFound();
            }
            return View(postPartida);
        }

        // POST: PostPartidas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PostPartida postPartida)
        {
            if (ModelState.IsValid)
            {
                PostPartida postPartidaOriginal = await _servicioEntrePartidas.GetPostPartida(postPartida.PostPartidaId);
                postPartidaOriginal.FechaFin = postPartida.FechaFin;
                postPartidaOriginal.FechaInicio = postPartida.FechaInicio;
                _servicioEntrePartidas.Actualizar(postPartidaOriginal);
                await _servicioEntrePartidas.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(postPartida);
        }
    }
}
