using Cronica.Modelos.Repositorios.Interfaces;
using Cronica.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronica.Modelos.ViewModels.PostPartidas;
using Microsoft.Data.Entity;

namespace Cronica.Modelos.Repositorios
{
    public class RepositorioPostPartidas : RepositorioBase, IRepositorioPostPartidas
    {
        
        public RepositorioPostPartidas(CronicaDbContext contexto) : base(contexto)
        {            
        }

        public async Task<PostPartida> GetPostPartida(int postPartidaId)
        {
            return await _contexto.PostPartidas.Include(p => p.PasaTramas).SingleAsync(p => p.PostPartidaId == postPartidaId);
        }

        public async Task<List<PostPartida>> GetPostPartidas()
        {
            return await _contexto.PostPartidas.ToListAsync();
        }

        public async Task<List<int>> GetPostPartidasIds()
        {
            return await _contexto.PostPartidas.Select(p => p.PostPartidaId).OrderBy(p=> p).ToListAsync();
        }

        public void IncluirPostPartida(PostPartida postPartida)
        {
            _contexto.PostPartidas.Add(postPartida);
        }
    }
}
