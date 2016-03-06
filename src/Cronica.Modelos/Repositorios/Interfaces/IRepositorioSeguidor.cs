using Cronica.Modelos.ViewModels.GestionPersonajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios.Interfaces
{
    public interface IRepositorioSeguidor : IRepositorioBase
    {
        Task<PersonaTrasfondo> GetSeguidor(int personajeId, int seguidorId);

        Task<List<SeguidorPotencial>> GetSeguidoresPotenciales(int personajeId);
        void GuardarSeguidor(PersonaTrasfondo seguidor);
    }
}
