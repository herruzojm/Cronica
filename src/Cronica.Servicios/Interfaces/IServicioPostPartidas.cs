using Cronica.Modelos.ViewModels.PostPartidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioPostPartidas : IServicioBase
    {        
        Task<List<PostPartida>> GetPostPartidas();
        Task<List<int>> GetPostPartidasIds();
        Task<PostPartida> GetPostPartida(int postPartidaId);
        Task<int> GetPostPartidaActualId();
        void IncluirPostPartida(PostPartida postPartida);
        Task<List<VistaFormularioPostPartida>> GetFormulariosSinTramitar();
        Task<List<VistaFormularioPostPartida>> GetFormulariosPostPartida();
    }
}
