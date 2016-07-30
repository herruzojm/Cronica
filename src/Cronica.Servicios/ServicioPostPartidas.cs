using Cronica.Servicios.Interfaces;
using Cronica.Modelos.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronica.Modelos.ViewModels.PostPartidas;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;

namespace Cronica.Servicios
{
    public class ServicioPostPartidas : ServicioBase, IServicioPostPartidas
    {


        public ServicioPostPartidas(CronicaDbContext contexto) : base(contexto)
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
            return await _contexto.PostPartidas.Select(p => p.PostPartidaId).OrderBy(p => p).ToListAsync();
        }

        public async Task<int> GetPostPartidaActualId()
        {
            return await _contexto.PostPartidas.Where(p => p.Activa == true).Select(p => p.PostPartidaId).FirstAsync();
        }

        public void IncluirPostPartida(PostPartida postPartida)
        {
            _contexto.PostPartidas.Add(postPartida);
        }

        public async Task<FormularioPostPartida> GetFormularioPostPartidaById(int formularioPostPartidaId)
        {
            return await _contexto.FormulariosPostPartida.Include(f => f.Personaje)
                .SingleAsync(f => f.FormularioPostPartidaId == formularioPostPartidaId);
        }

        public async Task<List<FormularioPostPartida>> GetFormulariosSinTramitar()
        {
            return await _contexto.FormulariosPostPartida.Where(f => f.Tramitado == false).
                Include(f => f.Personaje).Include(f => f.Jugador).ToListAsync();

        }
        public async Task<List<FormularioPostPartida>> GetFormulariosPostPartida()
        {
            return await _contexto.FormulariosPostPartida.Include(f => f.Personaje).Include(f => f.Jugador).Include(f => f.NarradorEncargado).ToListAsync();
        }
    }
}
