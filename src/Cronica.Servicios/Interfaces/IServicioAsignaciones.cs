using Cronica.Modelos.ViewModels.PostPartidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioAsignaciones : IServicioBase
    {
        Task<Asignacion> GetAsignacion(string jugadorId);
        Task<Asignacion> GetNuevaAsignacion(string jugadorId, int postPartidaId);
    }
}
