using Cronica.Servicios.Interfaces;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios
{
    public class ServicioJugadores : ServicioBase, IServicioJugadores
    {

        public ServicioJugadores(CronicaDbContext contexto) : base(contexto)
        {
        }

        public async Task<Personaje> GetMiPersonaje(string jugadorId)
        {
            Personaje personaje = await _contexto.Personajes
                .Include(p => p.Seguidores).ThenInclude(s => s.TrasfondoRelacionado)
                .Include(p => p.Atributos).ThenInclude(ap => ap.Atributo)
                .SingleAsync(p => p.JugadorId == jugadorId && p.Activo == true);
            return personaje;
        }

        public async Task<Personaje> GetMisTramas(string jugadorId)
        {
            Personaje personaje = await _contexto.Personajes
                .Include(p => p.TramasParticipadas).ThenInclude(tp => tp.Trama)
                .SingleAsync(p => p.JugadorId == jugadorId && p.Activo == true);
            return personaje;
        }
    }
}
