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

        public async Task<Trama> GetTrama(int tramaId)
        {
            return await _contexto.Tramas.Include(t=> t.Atributos).SingleAsync(t => t.TramaId == tramaId);
        }

        public async Task<List<Trama>> GetTramas()
        {
            return await _contexto.Tramas.Include(t=> t.Participantes).ToListAsync();
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
