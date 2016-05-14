using Cronica.Modelos.ViewModels.Tramas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioTramas : IServicioBase
    {
        Task<List<Trama>> GetTramas();
        Task<List<Trama>> GetTramasPersonaje(int personajeId);
        Task<Trama> GetTrama(int tramaId);
        Task<List<ParticipantesTrama>> GetParticipantesTrama(int tramaId);
        void IncluirTrama(Trama trama);
        Task<Trama> GetNuevaTrama(int? plantillaId);
        Task ActualizarTrama(Trama trama, VistaParticipantesTramas participantes);
    }
}
