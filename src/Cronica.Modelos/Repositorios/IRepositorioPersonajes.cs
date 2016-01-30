using Cronica.Modelos.ViewModels.GestionPersonaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios
{
    public interface IRepositorioPersonajes
    {
        Task<List<Personaje>> GetPersonajes();
        Task<Personaje> GetNuevoPersonaje();
        Task<Personaje> GetPersonaje(int personajeId);
        void IncluirPersonaje(Personaje personaje);
        Task<int> ConfirmarCambios();
        void ActualizarPersonaje(Personaje personaje);
        void EliminarPersonaje(Personaje personaje);
    }
}
