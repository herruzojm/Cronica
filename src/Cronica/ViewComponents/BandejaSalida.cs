using Cronica.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cronica.ViewComponents
{
    public class BandejaSalida : ViewComponent
    {

        private IServicioMensajeria _servicioMensajeria;
        private IServicioUsuarios _servicioUsuarios;

        public BandejaSalida(IServicioMensajeria servicioMensajeria, IServicioUsuarios servicioUsuarios)
        {
            _servicioMensajeria = servicioMensajeria;
            _servicioUsuarios = servicioUsuarios;
        }

        public async Task<IViewComponentResult> InvokeAsync(int personajeId, ClaimsPrincipal user)
        {
            ViewBag.Usuario = _servicioUsuarios.GetUser(user);
            return View(await _servicioMensajeria.GetMensajesEnviados(personajeId));
        }
    }
}
