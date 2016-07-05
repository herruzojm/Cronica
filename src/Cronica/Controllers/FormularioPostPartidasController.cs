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


        // GET: FormularioPostPartidas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FormularioPostPartida formularioPostPartida = await _servicioPostPartidas.GetFormularioPostPartidaById(id.Value);
            if (formularioPostPartida == null)
            {
                return NotFound();
            }
            return View(formularioPostPartida);
        }

        // POST: FormularioPostPartidas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(FormularioPostPartida formularioPostPartida)
        {
            if (ModelState.IsValid)
            {
                _servicioPostPartidas.Actualizar(formularioPostPartida);
                await _servicioPostPartidas.ConfirmarCambios();
                ViewBag.MensajeExito = $"Formulario actualizado";
                return View(formularioPostPartida);
            }
            ViewBag.MensajeError = $"Upps, parece que tenemos algún problemilla";
            return View(formularioPostPartida);
        }

        // GET: FormularioPostPartidas/PostPartidasPendientes
        public async Task<IActionResult> PostPartidasPendientes()
        {
            return View(await _servicioPostPartidas.GetFormulariosSinTramitar());
        }

        // GET: FormularioPostPartidas/FormulariosPostPartida
        public async Task<IActionResult> FormulariosPostPartida()
        {
            return View(await _servicioPostPartidas.GetFormulariosPostPartida());
        }

    }
}
