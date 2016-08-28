using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.ViewModels.Tramas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioJugadores : IServicioBase
    {
        string GetNombrePersonaje(string jugadorId);
        string GetFotoPersonaje(string jugadorId);
        int GetPersonajeId(string jugadorId);
        Task<Personaje> GetMiPersonaje(string jugadorId);
        Task<VistaTramas> GetMisTramas(string jugadorId);
        Task<VistaTramas> GetMisTramasCerradas(string jugadorId);
        Task<FormularioPostPartida> GetFormularioPostPartida(string jugadorId);
        Task<FormularioPostPartida> NuevoFormularioPostPartida(string jugadorId, int postPartidaId);
        Task EnviarFormularioPostPartida(FormularioPostPartida formularioPostPartida);
        void IncluirFormularioPostPartida(FormularioPostPartida formularioPostPartida);
    }
}
