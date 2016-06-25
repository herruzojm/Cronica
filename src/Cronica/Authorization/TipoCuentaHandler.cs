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
            //Dejamos continuar si tiene el tipo de cuenta requerido...
            if (context.User.FindFirst(c => c.Type == ClaimTypes.Role).Value == requirement.Cuenta.ToString())
            {
                context.Succeed(requirement);
            }
            else
            {
                //... o si se solicita Narrador y es administrador
                if (requirement.Cuenta == TipoCuenta.Narrador)
                {
                    if (context.User.FindFirst(c => c.Type == ClaimTypes.Role).Value == TipoCuenta.Administrador.ToString())
                    {
                        context.Succeed(requirement);
                    }
                }
            }            
        }

    }
}
