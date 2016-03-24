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
        void IncluirPostPartida(PostPartida postPartida);        
    }
}
