using Cronica.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronica.Modelos.ViewModels.PostPartida;
using Microsoft.Data.Entity;

namespace Cronica.Modelos.Repositorios
{
    public class RepositorioPostPartidas : IRepositorioPostPartidas
    {
        private CronicaDbContext _contexto;

        public RepositorioPostPartidas(CronicaDbContext contexto)
        {
            _contexto = contexto;
        }

        public void ActualizarPostPartida(PostPartida postPartida)
        {
            _contexto.Update(postPartida);
        }

        public async Task<int> ConfirmarCambios()
        {
            return await _contexto.SaveChangesAsync();
        }

        public void EliminarPostPartida(PostPartida postPartida)
        {
            _contexto.Remove(postPartida);
        }

        public async Task<PostPartida> GetPostPartida(int postPartidaId)
        {
            return await _contexto.PostPartidas.SingleAsync(p => p.PostPartidaId == postPartidaId);
        }

        public async Task<List<PostPartida>> GetPostPartidas()
        {
            return await _contexto.PostPartidas.ToListAsync();
        }

        public void IncluirPostPartida(PostPartida postPartida)
        {
            _contexto.PostPartidas.Add(postPartida);
        }
    }
}
