using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios
{
    public class RepositorioPersonajes : RepositorioBase, IRepositorioPersonajes
    {

        
        public RepositorioPersonajes(CronicaDbContext contexto) : base(contexto)
        {            
        }

        public async Task<List<Personaje>> GetPersonajes()
        {
            return await _contexto.Personajes.Include(p => p.Jugador).ToListAsync();
        }

        public async Task<Personaje> GetNuevoPersonaje()
        {
            Personaje personaje = new Personaje();
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
            Personaje personaje = await _contexto.Personajes
                .Include(p => p.Tramas)
                .Include(p => p.Seguidores).ThenInclude(s => s.TrasfondoRelacionado)
                .Include(p => p.Atributos).ThenInclude(ap => ap.Atributo)                
                .SingleAsync(m => m.PersonajeId == personajeId);
            return personaje;
        }

        public void IncluirPersonaje(Personaje personaje)
        {
            _contexto.Personajes.Add(personaje);
        }

        public async Task<List<Personaje>> GetPersonajesJugadores()
        {
            return await _contexto.Personajes.Include(p => p.Jugador)
                .Where(p=> p.Jugador.Cuenta == TipoCuenta.Jugador && p.Activo == true).ToListAsync();
        }

        public async Task<List<Personaje>> GetPNJs()
        {
            return await _contexto.Personajes.Include(p => p.Jugador)
                .Where(p => p.Jugador.Cuenta == TipoCuenta.Narrador && p.Activo == true).ToListAsync();
        }
    }
}
