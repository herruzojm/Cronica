using Cronica.Modelos.Models;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNetCore.Authorization;
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

        protected override void Handle(AuthorizationContext context, TipoCuentaRequirement requirement)
        {
            if (context.User.FindFirst(c => c.Type == ClaimTypes.Role).Value == requirement.Cuenta.ToString())
            {
                context.Succeed(requirement);
            }
        }

    }
}
