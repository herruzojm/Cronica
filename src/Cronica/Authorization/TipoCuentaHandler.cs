using Cronica.Modelos.Models;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Authorization;

namespace Cronica.Authorization
{
    public class TipoCuentaHandler : Microsoft.AspNetCore.Authorization.AuthorizationHandler<TipoCuentaRequirement>
    {
        private IServicioUsuarios _servicioUsuarios;

        public TipoCuentaHandler(IServicioUsuarios servicioUsuarios)
        {
            _servicioUsuarios = servicioUsuarios;
        }

        protected override void Handle(Microsoft.AspNetCore.Authorization.AuthorizationContext context, TipoCuentaRequirement requirement)
        {
            if (context.User.FindFirst(c => c.Type == ClaimTypes.Role).Value == requirement.Cuenta.ToString())
            {
                context.Succeed(requirement);
            }
        }

    }
}
