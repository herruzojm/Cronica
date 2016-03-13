using Cronica.Modelos.Models;
using Cronica.Modelos.Repositorios.Interfaces;
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
        private IRepositorioUsuarios _repositorioUsuarios;

        public TipoCuentaHandler(IRepositorioUsuarios repositorioUsuarios)
        {
            _repositorioUsuarios = repositorioUsuarios;
        }

        protected override async void Handle(AuthorizationContext context, TipoCuentaRequirement requirement)
        {

            ApplicationUser usuario = await _repositorioUsuarios.GetUsuarioById(context.User.GetUserId());

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
