using Cronica.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.Models;
using Microsoft.EntityFrameworkCore;

namespace Cronica.Servicios
{
    public class ServicioAsignaciones : ServicioBase, IServicioAsignaciones
    {
        public ServicioAsignaciones(CronicaDbContext contexto) : base(contexto)
        {
        }

        public async Task<Asignacion> GetAsignacion(string jugadorId)
        {
            var asignacion = await _contexto.Asignaciones
                .Include(a => a.Personaje).ThenInclude(p => p.Seguidores).ThenInclude(s => s.TrasfondoRelacionado)
                .Include(a => a.Personaje).ThenInclude(p => p.TramasParticipadas).ThenInclude(tp => tp.Trama)
                .Include(a => a.Asignaciones).ThenInclude(ap => ap.Personaje)
                .Include(a => a.Asignaciones).ThenInclude(ap => ap.Trama)
                .Where(a => a.Personaje.JugadorId == jugadorId && a.PasaTrama.Actual == true ).FirstOrDefaultAsync();

            return asignacion;
        }

        public async Task<Asignacion> GetNuevaAsignacion(string jugadorId, int postPartidaId)
        {
            //todo
            //Asignacion asignacion = new Asignacion();
            //asignacion.PersonajeId = personajeId;
            //asignacion.PostPartidaId = postPartidaId;

            //asignacion.Asignaciones.Add(new PersonajeAsignacion { PersonajeId = personajeId, PuntosParticipacion = 0 });
            //await _contexto.Personajes.Include(p => p.Seguidores)
            //            .Where(p => p.PersonajeId == personajeId)
            //            .SelectMany(p => p.Seguidores)
            //            .ForEachAsync(s =>
            //                asignacion.Asignaciones.Add (
            //                    new PersonajeAsignacion { PersonajeId = s.TrasfondoRelacionadoId, PuntosParticipacion = 0 }
            //                )
            //            );

            //return asignacion;
            return null;
        }
    }
}
