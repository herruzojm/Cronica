using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Cronica.Modelos.ViewModels.PostPartida;
using Cronica.Models;

namespace Cronica.Controllers
{
    public class PostPartidasController : Controller
    {
        private CronicaDbContext _context;

        public PostPartidasController(CronicaDbContext context)
        {
            _context = context;    
        }

        // GET: PostPartidas
        public async Task<IActionResult> Index()
        {
            return View(await _context.PostPartidas.ToListAsync());
        }

        // GET: PostPartidas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PostPartida postPartida = await _context.PostPartidas.SingleAsync(m => m.PostPartidaId == id);
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
                _context.PostPartidas.Add(postPartida);
                await _context.SaveChangesAsync();
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

            PostPartida postPartida = await _context.PostPartidas.SingleAsync(m => m.PostPartidaId == id);
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
                _context.Update(postPartida);
                await _context.SaveChangesAsync();
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

            PostPartida postPartida = await _context.PostPartidas.SingleAsync(m => m.PostPartidaId == id);
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
            PostPartida postPartida = await _context.PostPartidas.SingleAsync(m => m.PostPartidaId == id);
            _context.PostPartidas.Remove(postPartida);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
