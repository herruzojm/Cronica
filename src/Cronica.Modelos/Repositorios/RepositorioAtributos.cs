using Cronica.Modelos.ViewModels.Trama;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonaje;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.Data.Entity;
using System.Collections.Generic;

namespace Cronica.Modelos.Repositorios
{
    public class RepositorioAtributos : IRepositorioAtributos
    {
        private CronicaDbContext _contexto;

        public RepositorioAtributos(CronicaDbContext contexto)
        {
            _contexto = contexto;
        }

        public void ActualizarAtributo(Atributo atributo)
        {
            _contexto.Update(atributo);
        }

        public Task<int> ConfirmarCambios()
        {
            return _contexto.SaveChangesAsync();
        }

        public async Task<int> CrearAtributo(Atributo atributo)
        {
            _contexto.Atributos.Add(atributo);
            IncluirAtributoEnPersonajes(atributo);
            IncluirAtributoEnPlantillasTrama(atributo);
            return await _contexto.SaveChangesAsync();                
        }

        public async Task<Atributo> GetAtributo(int atributoId)
        {
            return await _contexto.Atributos.SingleAsync(a => a.AtributoId == atributoId);
        }

        public async Task<List<Atributo>> GetAtributos()
        {
            return await _contexto.Atributos.ToListAsync();
        }

        private void IncluirAtributoEnPersonajes(Atributo nuevoAtributo)
        {
            var personajes = _contexto.Personajes.ToList<Personaje>();
            personajes.ForEach(p => p.Atributos.Add(
                    new AtributoPersonaje() { AtributoId = nuevoAtributo.AtributoId, PersonajeId = p.PersonajeId, Valor = 0 }
                ));            
        }

        private void IncluirAtributoEnPlantillasTrama(Atributo nuevoAtributo)
        {
            var plantillasTrama = _contexto.PlantillasTrama.ToList();
            plantillasTrama.ForEach(p => p.Atributos.Add(
                    new AtributoPlantillaTrama() { AtributoId = nuevoAtributo.AtributoId, PlantillaTramaId = p.PlantillaTramaId, Multiplicador = 0 }
                ));            
        }

    }
}
