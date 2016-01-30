using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Cronica.Modelos.ViewModels.PostPartida;
using Cronica.Modelos.Models;
using Cronica.Modelos.Repositorios;

namespace Cronica.Controllers
{
    public class PostPartidasController : Controller
    {
        private IRepositorioPostPartidas _repositorioPostPartidas;

        public PostPartidasController(IRepositorioPostPartidas repositorioPostPartidas)
        {
            _repositorioPostPartidas = repositorioPostPartidas;    
        }

        // GET: PostPartidas
        public async Task<IActionResult> Index()
        {
            return View(await _repositorioPostPartidas.GetPostPartidas());
        }

        // GET: PostPartidas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PostPartida postPartida = await _repositorioPostPartidas.GetPostPartida(id.Value);
            if (postPartida == null)
            {
                return HttpNotFound();
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
                _repositorioPostPartidas.IncluirPostPartida(postPartida);
                await _repositorioPostPartidas.ConfirmarCambios();
                return RedirectToAction("Index");
            }
            return View(postPartida);
        }

        // GET: PostPartidas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PostPartida postPartida = await _repositorioPostPartidas.GetPostPartida(id.Value);
            if (postPartida == null)
            {
                return HttpNotFound();
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
                _repositorioPostPartidas.ActualizarPostPartida(postPartida);
                await _repositorioPostPartidas.ConfirmarCambios();
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
                return HttpNotFound();
            }

            PostPartida postPartida = await _repositorioPostPartidas.GetPostPartida(id.Value);
            if (postPartida == null)
            {
                return HttpNotFound();
            }

            return View(postPartida);
        }

        // POST: PostPartidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            PostPartida postPartida = await _repositorioPostPartidas.GetPostPartida(id);
            _repositorioPostPartidas.EliminarPostPartida(postPartida);
            await _repositorioPostPartidas.ConfirmarCambios();
            return RedirectToAction("Index");
        }
    }
}
