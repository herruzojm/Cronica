using Cronica.Modelos.ViewModels.Mensajeria;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cronica.ViewComponents
{
    public class NuevoMensaje : ViewComponent
    {

        private IServicioMensajeria _servicioMensajeria;

        public NuevoMensaje(IServicioMensajeria servicioMensajeria)
        {
            _servicioMensajeria = servicioMensajeria;
        }

        public async Task<IViewComponentResult> InvokeAsync(int personajeId)
        {
            Mensaje nuevoMensaje = new Mensaje();
            nuevoMensaje.RemitenteId = personajeId;
            return View(nuevoMensaje);
        }
    }
}
