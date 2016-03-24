using Cronica.Modelos.Models;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNet.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cronica.Authorization
{
    public class TipoCuentaHandler : AuthorizationHandler<TipoCuentaRequirement>
    {
        private IServicioUsuarios _servicioUsuarios;

        public TipoCuentaHandler(IServicioUsuarios servicioUsuarios)
        {
            _servicioUsuarios = servicioUsuarios;
        }

        protected override async void Handle(AuthorizationContext context, TipoCuentaRequirement requirement)
        {

            ApplicationUser usuario = await _servicioUsuarios.GetUsuarioById(context.User.GetUserId());

            if (usuario == null)
            {
                return;
            }
            if (usuario.Cuenta == requirement.Cuenta)
            {
                context.Succeed(requirement);

            }
        }
    }
}
