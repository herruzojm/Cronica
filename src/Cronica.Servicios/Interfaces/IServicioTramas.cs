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
        Task<Trama> GetTrama(int tramaId);
        Task<Trama> GetTramaConInterludio(int personajeId, int tramaId);
        Task<List<ParticipantesTrama>> GetParticipantesTrama(int tramaId);
        void IncluirTrama(Trama trama);
        Task<Trama> GetNuevaTrama(int? plantillaId);
        Task CrearTrama(Trama trama, VistaParticipantesTramas participantes);
        Task ActualizarTrama(Trama trama, VistaParticipantesTramas participantes);
    }
}
