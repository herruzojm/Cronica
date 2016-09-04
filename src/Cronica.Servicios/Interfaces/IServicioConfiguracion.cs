using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Modelos.ViewModels.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioConfiguracion : IServicioBase
    {
        Task<Configuracion> GetConfiguracion();
    }
}
