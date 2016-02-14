using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios
{
    public class RepositorioPlantillasTrama : RepositorioBase, IRepositorioPlantillasTrama
    {
        
        public RepositorioPlantillasTrama(CronicaDbContext contexto) : base(contexto)
        {        
        }
                
        public async Task<PlantillaTrama> GetNuevaPlantilla()
        {
            PlantillaTrama plantilla = new PlantillaTrama();
            plantilla.Atributos = new List<AtributoPlantillaTrama>();
            var atributos = await _contexto.Atributos.ToListAsync();
            foreach (Atributo atributo in atributos)
            {
                plantilla.Atributos.Add(new AtributoPlantillaTrama()
                { Multiplicador = 0, PlantillaTramaId = plantilla.PlantillaTramaId, AtributoId = atributo.AtributoId, Atributo = atributo });
            }
            return plantilla;
        }

        public async Task<List<PlantillaTrama>> GetPlantillasTrama()
        {
            return await _contexto.PlantillasTrama.ToListAsync();
        }

        public async Task<PlantillaTrama> GetPlantillaTrama(int plantillaTramaId)
        {
            PlantillaTrama plantilla = await _contexto.PlantillasTrama.Include(p => p.Atributos).
                ThenInclude(ap => ap.Atributo).SingleAsync(m => m.PlantillaTramaId == plantillaTramaId);
            return plantilla;
        }

        public void IncluirPlantillaTrama(PlantillaTrama plantillaTrama)
        {
            _contexto.PlantillasTrama.Add(plantillaTrama);
        }
    }
}
