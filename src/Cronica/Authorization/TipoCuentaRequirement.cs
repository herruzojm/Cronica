using Cronica.Modelos.Models;
using Microsoft.AspNetCore.Authorization;

namespace Cronica.Authorization
{
    public class TipoCuentaRequirement : IAuthorizationRequirement
    {
        public TipoCuenta Cuenta { get; set; }
        public TipoCuentaRequirement(TipoCuenta cuenta)
        {
            Cuenta = cuenta;
        }
    }
}
