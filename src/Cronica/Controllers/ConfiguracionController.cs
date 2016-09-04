using Cronica.Servicios.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Modelos.Models;
using Cronica.Servicios;
using Microsoft.AspNetCore.Authorization;
using Cronica.Modelos.ViewModels.Manage;

namespace Cronica.Controllers
{
    [Authorize(Policy = "Administrador")]
    public class ConfiguracionController : RutasController
    {
        private IServicioConfiguracion _servicioConfiguracion;

        public ConfiguracionController(IServicioConfiguracion servicioConfiguracion)
        {
            _servicioConfiguracion = servicioConfiguracion;
        }

        public async Task<IActionResult> Index()
        {
            Configuracion configuracion = await _servicioConfiguracion.GetConfiguracion();            
            return View(configuracion);
        }
        
        // POST: Atributo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Configuracion configuracion)
        {
            if (ModelState.IsValid)
            {
                _servicioConfiguracion.Actualizar(configuracion);
                await _servicioConfiguracion.ConfirmarCambios();
                ViewBag.MensajeExito = "Configuración guardada.";
                return View(configuracion);
            }
            ViewBag.MensajeError = $"Uppss... parece que tenemos algún problemilla guardando los datos.";
            return View(configuracion);
        }
    }
}
