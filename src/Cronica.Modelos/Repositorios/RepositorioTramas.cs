using Cronica.Modelos.Repositorios.Interfaces;
using Cronica.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronica.Modelos.ViewModels.Tramas;
using Microsoft.Data.Entity;
using Cronica.Modelos.ViewModels.GestionPersonajes;

namespace Cronica.Modelos.Repositorios
{
    public class RepositorioTramas : RepositorioBase, IRepositorioTramas
    {
        public RepositorioTramas(CronicaDbContext contexto) : base(contexto)
        {
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
                    trama.PlantillaId = plantillaId.Value;
                    foreach (AtributoPlantillaTrama atributoPlantilla in plantilla.Atributos)
                    {
                        trama.Atributos.Add(new AtributoTrama()
                        {
                            Multiplicador = atributoPlantilla.Multiplicador,
                            TramaId = trama.TramaId,
                            AtributoId = atributoPlantilla.AtributoId,
                            Atributo = atributos.Where(a => a.AtributoId == atributoPlantilla.AtributoId).FirstOrDefault()
                        });
                    }
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
            return await _contexto.Tramas.Include(t=> t.Personaje).ToListAsync();
        }

        public async Task<List<Trama>> GetTramasPersonaje(int personajeId)
        {
            return await _contexto.Tramas.Where(t=> t.PersonajeId == personajeId).ToListAsync();
        }

        public void IncluirTrama(Trama trama)
        {
            _contexto.Tramas.Add(trama);
        }
    }
}
