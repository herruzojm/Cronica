using Cronica.Modelos.ViewModels.PostPartida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios
{
    public interface IRepositorioPostPartidas
    {
        Task<List<PostPartida>> GetPostPartidas();        
        Task<PostPartida> GetPostPartida(int postPartidaId);
        void IncluirPostPartida(PostPartida postPartida);
        Task<int> ConfirmarCambios();
        void ActualizarPostPartida(PostPartida postPartida);
        void EliminarPostPartida(PostPartida postPartida);
    }
}
