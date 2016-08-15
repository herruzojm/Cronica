using Cronica.Modelos.ViewModels.PostPartidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioEntrePartidas : IServicioBase
    {        
        Task<List<EntrePartida>> GetEntrePartidas();
        Task<List<int>> GetEntrePartidasIds();
        Task<EntrePartida> GetEntrePartida(int entrePartidaId);
        Task<int> GetEntrePartidaActualId();
        void IncluirEntrePartida(EntrePartida entrePartida);
        Task<FormularioPostPartida> GetFormularioPostPartidaById(int formularioEntrePartidaId);
        Task<List<FormularioPostPartida>> GetFormulariosSinTramitar();
        Task<List<FormularioPostPartida>> GetFormulariosPostPartida();
    }
}
