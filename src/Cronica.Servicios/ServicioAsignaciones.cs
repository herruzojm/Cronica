using Cronica.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.Models;
using Microsoft.EntityFrameworkCore;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Modelos.ViewModels.Tramas;

namespace Cronica.Servicios
{
    public class ServicioAsignaciones : ServicioBase, IServicioAsignaciones
    {
        public ServicioAsignaciones(CronicaDbContext contexto) : base(contexto)
        {
        }

        public async Task<Asignacion> GetAsignacion(string jugadorId, bool reInvocado = false)
        {
            if (_contexto.Interludios.Count() > 0)
            {
                Asignacion asignacion = await _contexto.Asignaciones
                .Include(a => a.Personaje).ThenInclude(p => p.Seguidores).ThenInclude(s => s.TrasfondoRelacionado)
                .Include(a => a.Personaje).ThenInclude(p => p.TramasParticipadas).ThenInclude(tp => tp.Trama)
                .Include(a => a.Asignaciones).ThenInclude(ap => ap.Personaje)
                .Include(a => a.Asignaciones).ThenInclude(ap => ap.Trama)
                .Where(a => a.Personaje.JugadorId == jugadorId && a.Interludio.Actual == true).FirstOrDefaultAsync();

                // si no hay asignacion, creamos una nueva y la recuperamos
                // asegurandonos de no volver a invocar el proceso para no caer en un bucle infinito
                if (!reInvocado && (asignacion == null || asignacion.Asignaciones.Count() == 0))
                {
                    await CreateNuevaAsignacion(jugadorId);
                    asignacion = await GetAsignacion(jugadorId, true);
                }

                // comprobamos que el numero de asignaciones se corresponden con seguidores y tramas
                if (asignacion != null && !reInvocado)
                {
                    bool recargar = false;
                    if ((asignacion.Personaje.Seguidores.Count() + 1) * asignacion.Personaje.TramasParticipadas.Count() > asignacion.Asignaciones.Count())
                    {
                        //tenemos menos asignaciones de las que deberiamos, hay que crear las que faltan
                        await CreateAsignacionesRestantes(asignacion);
                        recargar = true;
                    }
                    if ((asignacion.Personaje.Seguidores.Count() + 1) * asignacion.Personaje.TramasParticipadas.Count() < asignacion.Asignaciones.Count())
                    {
                        //tenemos mas asignaciones de las que deberiamos, hay que borrar las que sobran
                        await DeleteAsignacionesSobrantes(asignacion);
                        recargar = true;
                    }
                    //si hemos borrado o añadido asignaciones, volvemos a recargar el objeto antes de devolverlo a la UI
                    if (recargar)
                    {
                        asignacion = await GetAsignacion(jugadorId, true);
                    }
                }

                return asignacion;
            }
            return null;
        }

        private async Task CreateNuevaAsignacion(string jugadorId)
        {

            Asignacion asignacion = new Asignacion();
            asignacion.InterludioId = _contexto.Interludios.Single(p => p.Actual == true).InterludioId;
            Personaje personaje = await _contexto.Personajes.
                Include(p => p.Seguidores).Include(p => p.TramasParticipadas)
                .SingleAsync(p => p.JugadorId == jugadorId);
            asignacion.PersonajeId = personaje.PersonajeId;

            PersonajeAsignacion nuevaAsignacion;
            foreach (ParticipantesTrama trama in personaje.TramasParticipadas)
            {
                foreach (PersonaTrasfondo seguidor in personaje.Seguidores)
                {
                    nuevaAsignacion = new PersonajeAsignacion
                    {
                        PersonajeId = seguidor.TrasfondoRelacionadoId,
                        TramaId = trama.TramaId,
                        PuntosParticipacion = 0
                    };
                    asignacion.Asignaciones.Add(nuevaAsignacion);
                }
                nuevaAsignacion = new PersonajeAsignacion
                {
                    PersonajeId = personaje.PersonajeId,
                    TramaId = trama.TramaId,
                    PuntosParticipacion = 0
                };
                asignacion.Asignaciones.Add(nuevaAsignacion);
            }

            _contexto.Asignaciones.Add(asignacion);
            await ConfirmarCambios();
        }

        private async Task CreateAsignacionesRestantes(Asignacion asignacion)
        {
            foreach (ParticipantesTrama trama in asignacion.Personaje.TramasParticipadas)
            {
                foreach (PersonaTrasfondo seguidor in asignacion.Personaje.Seguidores)
                {
                    if (asignacion.Asignaciones.
                        Where(a => a.PersonajeId == seguidor.TrasfondoRelacionadoId && a.TramaId == trama.TramaId).Count() == 0)
                    {
                        asignacion.Asignaciones.Add(new PersonajeAsignacion
                        {
                            PersonajeId = seguidor.TrasfondoRelacionadoId,
                            TramaId = trama.TramaId,
                            PuntosParticipacion = 0
                        });
                    }
                }
                if (asignacion.Asignaciones.
                        Where(a => a.PersonajeId == asignacion.PersonajeId && a.TramaId == trama.TramaId).Count() == 0)
                {
                    asignacion.Asignaciones.Add(new PersonajeAsignacion
                    {
                        PersonajeId = asignacion.PersonajeId,
                        TramaId = trama.TramaId,
                        PuntosParticipacion = 0
                    });
                }
            }

            await ConfirmarCambios();
        }

        private async Task DeleteAsignacionesSobrantes(Asignacion asignacion)
        {
            List<int> tramas = asignacion.Personaje.TramasParticipadas.Select(tp => tp.TramaId).Distinct().ToList();
            List<int> seguidores = asignacion.Personaje.Seguidores.Select(s => s.TrasfondoRelacionadoId).Distinct().ToList();
            seguidores.Add(asignacion.PersonajeId); //incluimos el id del personaje en la lista de seguidores para facilitar la busqueda

            PersonajeAsignacion asignacionParaBorrar;
            foreach (PersonajeAsignacion personajeAsignacion in asignacion.Asignaciones)
            {
                //si el id de la trama o del seguidor/personaje no esta en las listas de ids de tramas o de seguidores, 
                //la asignacion sobra
                if (!tramas.Contains(personajeAsignacion.TramaId) || !seguidores.Contains(personajeAsignacion.PersonajeId))
                {
                    asignacionParaBorrar = asignacion.Asignaciones.
                        Where(a => a.PersonajeId == personajeAsignacion.PersonajeId && a.TramaId == personajeAsignacion.TramaId).FirstOrDefault();
                    this.Eliminar(asignacionParaBorrar);
                }
            }

            await ConfirmarCambios();
        }
    }
}
