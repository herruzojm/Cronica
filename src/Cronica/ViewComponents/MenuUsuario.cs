using Cronica.Modelos.Models;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNet.Mvc;
using System.Security.Claims;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace Cronica.ViewComponents
{
    public class MenuUsuario : ViewComponent
    {
        private IServicioUsuarios _servicioUsuarios;

        public MenuUsuario(IServicioUsuarios servicioUsuarios)
        {
            _servicioUsuarios = servicioUsuarios;
        }

        public async Task<IViewComponentResult> InvokeAsync(string userId)
        {
            ApplicationUser usuario = await _servicioUsuarios.GetUsuarioById(userId);            
            return View(usuario);
        }

    }
}
