using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Modelos.ViewModels.PostPartidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioJugadores : IServicioBase
    {
        Task<string> GetNombrePersonaje(string jugadorId);
        Task<string> GetFotoPersonaje(string jugadorId);
        Task<Personaje> GetMiPersonaje(string jugadorId);
        Task<Personaje> GetMisTramas(string jugadorId);
        Task<FormularioPostPartida> GetFormularioPostPartida(string jugadorId);
        Task<FormularioPostPartida> NuevoFormularioPostPartida(string jugadorId, int postPartidaId);
        Task EnviarFormularioPostPartida(FormularioPostPartida formularioPostPartida);
        void IncluirFormularioPostPartida(FormularioPostPartida formularioPostPartida);
    }
}
