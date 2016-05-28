using Cronica.Servicios.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Modelos.Models;
using Cronica.Servicios;
using Microsoft.AspNet.Authorization;

namespace Cronica.Controllers
{
    [Authorize(Policy = "Narrador")]
    public class AtributosController : RutasController
    {
        private IServicioAtributos _servicioAtributos;

        public AtributosController(IServicioAtributos servicioAtributos)
        {
            _servicioAtributos = servicioAtributos;
        }

        // GET: Atributo
        public async Task<IActionResult> Index()
        {
            return View(await _servicioAtributos.GetAtributos());
        }

        // GET: Atributo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Atributo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Atributo atributo)
        {
            if (ModelState.IsValid)
            {                
                await _servicioAtributos.CrearAtributo(atributo);
                return RedirectToAction("Index");
            }
            return View(atributo);
        }

        // GET: Atributo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Atributo atributoViewModel = await _servicioAtributos.GetAtributo(id.Value);
            if (atributoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(atributoViewModel);
        }

        // POST: Atributo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Atributo atributo)
        {
            if (ModelState.IsValid)
            {
                _servicioAtributos.Actualizar(atributo);
                await _servicioAtributos.ConfirmarCambios();

                return RedirectToAction("Index");
            }
            return View(atributo);
        }
    }
}
