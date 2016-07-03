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
    [Authorize(Policy = "Narrador")]
    public class FormularioPostPartidasController : RutasController
    {
        private IServicioPostPartidas _servicioPostPartidas;

        public FormularioPostPartidasController(IServicioPostPartidas servicioPostPartidas)
        {
            _servicioPostPartidas = servicioPostPartidas;    
        }

        
        // GET: PostPartidas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PostPartida postPartida = await _servicioPostPartidas.GetPostPartida(id.Value);
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
                _servicioPostPartidas.Actualizar(postPartida);
                await _servicioPostPartidas.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(postPartida);
        }

        // GET: PostPartidasPendientes
        public async Task<IActionResult> PostPartidasPendientes()
        {
            return View(await _servicioPostPartidas.GetFormulariosSinTramitar());
        }

        // GET: FormulariosPostPartida
        public async Task<IActionResult> FormulariosPostPartida()
        {
            return View(await _servicioPostPartidas.GetFormulariosPostPartida());
        }

    }
}
