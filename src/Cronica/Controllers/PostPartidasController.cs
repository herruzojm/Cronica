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
    public class PostPartidasController : RutasController
    {
        private IServicioPostPartidas _servicioPostPartidas;

        public PostPartidasController(IServicioPostPartidas servicioPostPartidas)
        {
            _servicioPostPartidas = servicioPostPartidas;    
        }

        // GET: PostPartidas
        public async Task<IActionResult> Index()
        {
            return View(await _servicioPostPartidas.GetPostPartidas());
        }

        // GET: PostPartidas/Details/5
        public async Task<IActionResult> Details(int? id)
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
                _servicioPostPartidas.IncluirPostPartida(postPartida);
                await _servicioPostPartidas.ConfirmarCambios();
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

        // GET: PostPartidas/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
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

        // POST: PostPartidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            PostPartida postPartida = await _servicioPostPartidas.GetPostPartida(id);
            _servicioPostPartidas.Eliminar(postPartida);
            await _servicioPostPartidas.ConfirmarCambios();
            return RedirectToAction("Index");
        }
    }
}
