using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.ViewModels.Tramas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios.Interfaces
{
    public interface IRepositorioPasaTramas : IRepositorioBase
    {
        Task<PasaTrama> GetNuevoPasaTrama();
        Task<List<PasaTrama>> GetPasaTramas();
        Task<PasaTrama> GetPasaTrama(int pasaTramaId);
        void IncluirPasaTrama(PasaTrama pasaTrama);        
    }
}
