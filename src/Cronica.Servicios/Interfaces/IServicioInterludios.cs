using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.ViewModels.Tramas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioInterludios : IServicioBase
    {
        Task<PasaTrama> GetNuevoInterludio();
        Task<List<PasaTrama>> GetInterludios();
        Task<PasaTrama> GetInterludio(int interludioId);
        void IncluirPasaTrama(PasaTrama interludio);
        Task<bool> ResolverInterludio(PasaTrama interludio);
    }
}
