using Cronica.Modelos.Models;
using Microsoft.AspNet.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
