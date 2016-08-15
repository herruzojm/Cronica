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
    public class ServicioEntrePartidas : ServicioBase, IServicioEntrePartidas
    {


        public ServicioEntrePartidas(CronicaDbContext contexto) : base(contexto)
        {
        }

        public async Task<EntrePartida> GetEntrePartida(int entrePartidaId)
        {
            return await _contexto.EntrePartidas.Include(p => p.Interludios).SingleAsync(p => p.EntrePartidaId == entrePartidaId);
        }

        public async Task<List<EntrePartida>> GetEntrePartidas()
        {
            return await _contexto.EntrePartidas.ToListAsync();
        }

        public async Task<List<int>> GetEntrePartidasIds()
        {
            return await _contexto.EntrePartidas.Select(p => p.EntrePartidaId).OrderBy(p => p).ToListAsync();
        }

        public async Task<int> GetEntrePartidaActualId()
        {
            return await _contexto.EntrePartidas.Where(p => p.Activa == true).Select(p => p.EntrePartidaId).FirstAsync();
        }

        public void IncluirEntrePartida(EntrePartida entrePartida)
        {
            _contexto.EntrePartidas.Add(entrePartida);
        }

        public async Task<FormularioPostPartida> GetFormularioPostPartidaById(int formularioEntrePartidaId)
        {
            return await _contexto.FormulariosPostPartida.Include(f => f.Personaje)
                .SingleAsync(f => f.FormularioPostPartidaId == formularioEntrePartidaId);
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
