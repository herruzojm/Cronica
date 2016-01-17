using Cronica.Models;
using Cronica.ViewModels.Personaje;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.LogicaPersonajes
{
    public class LogicaPersonajes
    {

        private CronicaDbContext _contexto;

        public LogicaPersonajes(CronicaDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<Personaje> GetNuevoPersonaje()
        {
            Personaje personaje = new Personaje();
            personaje.Atributos = new List<AtributoPersonaje>();
            var atributos = await _contexto.Atributos.ToListAsync();
            foreach (Atributo atributo in atributos)
            {
                personaje.Atributos.Add(new AtributoPersonaje()
                { Valor = 0, PersonajeId = personaje.PersonajeId, AtributoId = atributo.AtributoId, Atributo = atributo });
            }
            return personaje;
        }

        public async Task<Personaje> GetPersonaje(int personajeId)
        {
            Personaje personaje = await _contexto.Personajes.Include(p => p.Atributos).
                ThenInclude(ap => ap.Atributo).SingleAsync(m => m.PersonajeId == personajeId);            
            return personaje;
        }
    }
}
