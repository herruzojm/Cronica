using Cronica.Servicios.Interfaces;
using Cronica.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronica.Modelos.ViewModels.Tramas;
using Microsoft.Data.Entity;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using AutoMapper;

namespace Cronica.Servicios
{
    public class ServicioTramas : ServicioBase, IServicioTramas
    {

        private IMapper _mapper;

        public ServicioTramas(CronicaDbContext contexto, IMapper mapper) : base(contexto)
        {
            _mapper = mapper;
        }

        public async Task ActualizarTrama(Trama trama, VistaParticipantesTramas vistaParticipantes)
        {
            //primero, borrar los participantes previos
            trama.Participantes = await GetParticipantesTrama(trama.TramaId);
            trama.Participantes.ForEach(p => Eliminar(p));
            Actualizar(trama);
            await ConfirmarCambios();

            //incluir nuevos participantes
            trama.Participantes = new List<ParticipantesTrama>();
            ParticipantesTrama nuevoParticipante;
            if (trama.TipoTrama == TipoTrama.Enfrentada)
            {
                var grupos = Enum.GetValues(typeof(TipoEquipo)).Cast<TipoEquipo>();
                foreach (var grupo in grupos)
                {
                    if ((int)grupo < vistaParticipantes.GrupoParticipantesIds.Length)
                    {
                        foreach (string participante in vistaParticipantes.GrupoParticipantesIds[(int)grupo])
                        {
                            nuevoParticipante = new ParticipantesTrama();
                            nuevoParticipante.PersonajeId = Convert.ToInt32(participante);
                            nuevoParticipante.TramaId = trama.TramaId;
                            nuevoParticipante.Equipo = grupo;
                            trama.Participantes.Add(nuevoParticipante);
                        }
                    }
                }
            }
            else
            {                
                foreach (string participante in vistaParticipantes.ParticipantesIds)
                {
                    nuevoParticipante = new ParticipantesTrama();
                    nuevoParticipante.PersonajeId = Convert.ToInt32(participante);
                    nuevoParticipante.TramaId = trama.TramaId;
                    nuevoParticipante.Equipo = TipoEquipo.A;
                    trama.Participantes.Add(nuevoParticipante);
                }
            }

            //guardar cambios
            Actualizar(trama);
            await ConfirmarCambios();

        }

        public async Task<Trama> GetNuevaTrama(int? plantillaId)
        {
            Trama trama = new Trama();
            var atributos = await _contexto.Atributos.ToListAsync();
            if (plantillaId.HasValue)
            {                
                var plantilla = await _contexto.PlantillasTrama.Include(p => p.Atributos)
                    .Where(p => p.PlantillaTramaId == plantillaId).FirstOrDefaultAsync();
                if (plantilla != null)
                {
                    trama = _mapper.Map<Trama>(plantilla);
                    trama.PlantillaId = plantillaId.Value;                    
                }
                             
            }
            if (trama.Atributos.Count == 0)
            {                
                foreach (Atributo atributo in atributos)
                {
                    trama.Atributos.Add(new AtributoTrama()
                    { Multiplicador = 0, TramaId = trama.TramaId, AtributoId = atributo.AtributoId, Atributo = atributo });
                }
            }            
            return trama;
        }

        public async Task<List<ParticipantesTrama>> GetParticipantesTrama(int tramaId)
        {
            return await _contexto.ParticipantesTrama.Where(pt => pt.TramaId == tramaId).ToListAsync();
        }

        public async Task<Trama> GetTrama(int tramaId)
        {
            return await _contexto.Tramas.Include(t=> t.Atributos).ThenInclude(at => at.Atributo).SingleAsync(t => t.TramaId == tramaId);
        }

        public async Task<List<Trama>> GetTramas()
        {
            return await _contexto.Tramas.Include(t=> t.Participantes).ThenInclude(p=> p.Personaje).ToListAsync();
        }

        public async Task<List<Trama>> GetTramasPersonaje(int personajeId)
        {
            return await (from trama in _contexto.Tramas join participantes in _contexto.ParticipantesTrama on trama.TramaId  equals participantes.TramaId
                         where participantes.PersonajeId == personajeId select trama).ToListAsync();
        }

        public void IncluirTrama(Trama trama)
        {
            _contexto.Tramas.Add(trama);
        }
    }
}
