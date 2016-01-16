using Cronica.Models;
using Cronica.ViewModels.Personaje;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cronica.Modelos.LogicaPersonajes
{
    public class DatosPersonajes
    {

        private CronicaDbContext _contexto;

        public DatosPersonajes(CronicaDbContext contexto)
        {
            _contexto = contexto;
        }

        public Personaje GetNuevoPersonaje()
        {
            Personaje personaje = new Personaje();
            personaje.Atributos = new List<AtributoPersonaje>();
            foreach (Atributo atributo in _contexto.Atributos)
            {
                personaje.Atributos.Add(new AtributoPersonaje()
                { Valor = 0, PersonajeId = personaje.Id, AtributoId = atributo.Id, Atributo = atributo });
            }
            return personaje;
        }

        public Personaje GetPersonaje(int personajeId)
        {
            Personaje personaje = _contexto.Personajes.Include(p => p.Atributos).
                ThenInclude(ap => ap.Atributo).Single(m => m.Id == personajeId);            
            return personaje;
        }
    }
}
