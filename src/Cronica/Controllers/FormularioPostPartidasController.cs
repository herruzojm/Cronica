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
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Cronica.Controllers
{
    [Authorize(Policy = "Narrador")]
    public class FormularioPostPartidasController : RutasController
    {
        private IServicioPostPartidas _servicioPostPartidas;
        private UserManager<ApplicationUser> _userManager;
        private IServicioUsuarios _servicioUsuarios;

        public FormularioPostPartidasController(IServicioPostPartidas servicioPostPartidas,
            IServicioUsuarios servicioUsuarios,
            UserManager<ApplicationUser> userManager)
        {
            _servicioPostPartidas = servicioPostPartidas;
            _userManager = userManager;
            _servicioUsuarios = servicioUsuarios;
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
            CargarListaNarradores();
            CargarListaJugadores();

            return View(formularioPostPartida);
        }

        // POST: FormularioPostPartidas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(FormularioPostPartida formularioPostPartida)
        {
            CargarListaNarradores();
            CargarListaJugadores();
            if (ModelState.IsValid)
            {    
                if (formularioPostPartida.Tramitado && formularioPostPartida.NarradorEncargadoId == null)
                {
                    formularioPostPartida.NarradorEncargadoId = await _servicioUsuarios.GetUserId(User);
                }
                _servicioPostPartidas.Actualizar(formularioPostPartida);
                await _servicioPostPartidas.ConfirmarCambios();
                formularioPostPartida = await _servicioPostPartidas.GetFormularioPostPartidaById(formularioPostPartida.FormularioPostPartidaId);
                ViewBag.MensajeExito = $"Formulario actualizado";
                return View("Edit", formularioPostPartida);
            }
            formularioPostPartida = await _servicioPostPartidas.GetFormularioPostPartidaById(formularioPostPartida.FormularioPostPartidaId);
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

        private void CargarListaJugadores()
        {
            List<SelectListItem> jugadores = new List<SelectListItem>();
            jugadores.AddRange(_servicioUsuarios.GetUsuarios().Result.Select(u => new SelectListItem
            {
                Value = u.Id,
                Text = u.UserName
            }).ToList());
            ViewBag.Jugadores = jugadores;
        }

        private void CargarListaNarradores()
        {
            List<SelectListItem> narradores = new List<SelectListItem>();
            narradores.Add(new SelectListItem() { Value = "", Text = "" });
            narradores.AddRange( _servicioUsuarios.GetNarradores().Result.Select(u => new SelectListItem
            {
                Value = u.Id,
                Text = u.UserName
            }).ToList());
            ViewBag.Narradores = narradores;
        }
    }
}
