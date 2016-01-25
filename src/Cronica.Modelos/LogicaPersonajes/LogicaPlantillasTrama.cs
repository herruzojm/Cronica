using Cronica.Modelos.ViewModels.Trama;
using Cronica.Models;
using Cronica.ViewModels.Personaje;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.LogicaPersonajes
{
    public class LogicaPlantillasTrama
    {
        private CronicaDbContext _contexto;

        public LogicaPlantillasTrama(CronicaDbContext contexto)
        {
            _contexto = contexto;
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

        public async Task<PlantillaTrama> GetPlantillaTrama(int plantillaTramaId)
        {
            PlantillaTrama plantilla = await _contexto.PlantillasTrama.Include(p => p.Atributos).
                ThenInclude(ap => ap.Atributo).SingleAsync(m => m.PlantillaTramaId == plantillaTramaId);
            return plantilla;
        }

    }
}
