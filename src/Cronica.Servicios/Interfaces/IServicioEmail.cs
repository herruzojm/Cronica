using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioEmail
    {
        void EnviarAltaCuenta(string cuentaUsuario, string password);
    }
}
