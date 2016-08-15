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
        Task<Interludio> GetNuevoInterludio();
        Task<List<Interludio>> GetInterludios();
        Task<Interludio> GetInterludio(int interludioId);
        void IncluirInterludio(Interludio interludio);
        Task<bool> ResolverInterludio(Interludio interludio);
    }
}
