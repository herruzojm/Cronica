using Cronica.Modelos.ViewModels.GestionPersonajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios
{
    public interface IRepositorioPersonajes : IRepositorioBase
    {
        Task<List<Personaje>> GetPersonajes();
        Task<Personaje> GetNuevoPersonaje();
        Task<Personaje> GetPersonaje(int personajeId);
        void IncluirPersonaje(Personaje personaje);        
        Task<List<Personaje>> GetPersonajesJugadores();
        Task<List<Personaje>> GetPNJs();
    }
}
