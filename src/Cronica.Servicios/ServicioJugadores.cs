using Cronica.Servicios.Interfaces;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using Cronica.Modelos.ViewModels.PostPartidas;
using System.Linq;
using Cronica.Modelos.ViewModels.Tramas;

namespace Cronica.Servicios
{
    public class ServicioJugadores : ServicioBase, IServicioJugadores
    {

        public ServicioJugadores(CronicaDbContext contexto) : base(contexto)
        {
        }
        
        public async Task<Personaje> GetMiPersonaje(string jugadorId)
        {
            Personaje personaje = await _contexto.Personajes
                .Include(p => p.Seguidores).ThenInclude(s => s.TrasfondoRelacionado)
                .Include(p => p.Atributos).ThenInclude(ap => ap.Atributo)
                .SingleAsync(p => p.JugadorId == jugadorId && p.Activo == true);
            return personaje;
        }

        public async Task<VistaTramas> GetMisTramas(string jugadorId)
        {
            return await (from personaje in _contexto.Personajes where personaje.JugadorId == jugadorId && personaje.Activo == true
                          select new VistaTramas
                          {
                              NombrePersonaje = personaje.Nombre,
                              PersonajeId = personaje.PersonajeId,
                              Tramas = (from trama in _contexto.Tramas join participante in _contexto.ParticipantesTrama
                                        on trama.TramaId equals participante.TramaId
                                        where participante.PersonajeId == personaje.PersonajeId && trama.Cerrada == false
                                        select new VistaListaTrama
                                        {
                                            TramaId = trama.TramaId,
                                            Descripcion = trama.Descripcion,
                                            Nombre = trama.Nombre,
                                            TextoResolucion = trama.TextoResolucion
                                        }
                              ).ToList()
                          }).FirstOrDefaultAsync();
        }

        public async Task<VistaTramas> GetMisTramasCerradas(string jugadorId)
        {
            return await (from personaje in _contexto.Personajes
                          where personaje.JugadorId == jugadorId && personaje.Activo == true
                          select new VistaTramas
                          {
                              NombrePersonaje = personaje.Nombre,
                              PersonajeId = personaje.PersonajeId,
                              Tramas = (from trama in _contexto.Tramas
                                        join participante in _contexto.ParticipantesTrama
                                        on trama.TramaId equals participante.TramaId
                                        where participante.PersonajeId == personaje.PersonajeId && trama.Cerrada == true
                                        select new VistaListaTrama
                                        {
                                            TramaId = trama.TramaId,
                                            Descripcion = trama.Descripcion,
                                            Nombre = trama.Nombre,
                                            TextoResolucion = trama.TextoResolucion
                                        }
                              ).ToList()
                          }).FirstOrDefaultAsync();
        }

        public async Task<string> GetNombrePersonaje(string jugadorId)
        {
            return _contexto.Personajes.SingleAsync(p => p.JugadorId == jugadorId && p.Activo == true).Result.Nombre;
        }

        public async Task<string> GetFotoPersonaje(string jugadorId)
        {
            return _contexto.Personajes.SingleAsync(p => p.JugadorId == jugadorId && p.Activo == true).Result.Foto;
        }

        public async Task<FormularioPostPartida> GetFormularioPostPartida(string jugadorId)
        {
            FormularioPostPartida formulario = await _contexto.FormulariosPostPartida.
                SingleOrDefaultAsync(f => f.JugadorId == jugadorId && f.Personaje.Activo == true && f.PostPartida.Activa == true);            
            return formulario;
        }

        public async Task<FormularioPostPartida> NuevoFormularioPostPartida(string jugadorId, int postPartidaId)
        {
            FormularioPostPartida formulario = new FormularioPostPartida();
            formulario.JugadorId = jugadorId;
            formulario.PersonajeId = await GetMiPetdonajeId(jugadorId);
            formulario.EntrePartidaId = postPartidaId;

            return formulario;
        }

        public async Task EnviarFormularioPostPartida(FormularioPostPartida formularioPostPartida)
        {
            formularioPostPartida.Enviado = true;
            formularioPostPartida.FechaEnvio = DateTime.Now;
            Actualizar(formularioPostPartida);
            await ConfirmarCambios();
        }

        public async Task<int> GetMiPetdonajeId(string jugadorId)
        {
            return await _contexto.Personajes.Where(p => p.JugadorId == jugadorId && p.Activo == true).Select(p => p.PersonajeId).FirstAsync();
        }
        public void IncluirFormularioPostPartida(FormularioPostPartida formularioPostPartida)
        {
            _contexto.FormulariosPostPartida.Add(formularioPostPartida);
        }

    }
}
