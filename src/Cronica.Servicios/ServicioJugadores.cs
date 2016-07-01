using Cronica.Servicios.Interfaces;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

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

        public async Task<string> GetNombrePersonaje(string jugadorId)
        {
            return _contexto.Personajes.SingleAsync(p => p.JugadorId == jugadorId && p.Activo == true).Result.Nombre;
        }
    }
}
