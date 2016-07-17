using Cronica.Modelos.ViewModels.GestionPersonajes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioPersonajes : IServicioBase
    {        
        Task<List<Personaje>> GetPersonajes();
        Task<Personaje> GetNuevoPersonaje();        
        Task<Personaje> GetPersonajeCompleto(int personajeId);
        Task<Personaje> GetPersonaje(int personajeId);
        void IncluirPersonaje(Personaje personaje);        
        Task<List<Personaje>> GetPersonajesJugadores();
        Task<List<Personaje>> GetPNJs();
        Task<bool> ActualizarPersonaje(Personaje personaje);
    }
}
