using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios
{
    public class RepositorioPersonajes : IRepositorioPersonajes
    {

        private CronicaDbContext _contexto;

        public RepositorioPersonajes(CronicaDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<Personaje>> GetPersonajes()
        {
            return await _contexto.Personajes.Include(p => p.Jugador).ToListAsync();
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

        public void IncluirPersonaje(Personaje personaje)
        {
            _contexto.Personajes.Add(personaje);
        }

        public Task<int> ConfirmarCambios()
        {
            return _contexto.SaveChangesAsync();
        }

        public void ActualizarPersonaje(Personaje personaje)
        {
            _contexto.Update(personaje);
        }

        public void EliminarPersonaje(Personaje personaje)
        {
            _contexto.Personajes.Remove(personaje);
        }
    }
}
