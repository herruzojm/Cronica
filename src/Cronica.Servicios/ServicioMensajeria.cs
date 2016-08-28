using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronica.Modelos.Models;
using Cronica.Servicios.Interfaces;
using Cronica.Modelos.ViewModels.Mensajeria;
using Microsoft.EntityFrameworkCore;

namespace Cronica.Servicios
{
    public class ServicioMensajeria : ServicioBase, IServicioMensajeria
    {
        public ServicioMensajeria(CronicaDbContext contexto) : base(contexto)
        {
        }

        public async Task<List<MensajeBandejaEntrada>> GetMensajesRecibidos(int personajeId)
        {
            return await (from mensaje in _contexto.Mensajes
                          join destinatario in _contexto.DestinatariosMensaje on mensaje.MensajeId equals destinatario.MensajeId
                          join personaje in _contexto.Personajes on mensaje.RemitenteId equals personaje.PersonajeId
                          where destinatario.DestinatarioId == personajeId && destinatario.EstadoMensaje != EstadoMensaje.Borrado
                          select new MensajeBandejaEntrada
                          {
                              Asunto = mensaje.Asunto,
                              EnviadoComo = mensaje.NombreParaMostrar,
                              EsAnonimo = mensaje.EsAnonimo,
                              Estado = destinatario.EstadoMensaje,
                              FechaEnvio = mensaje.FechaCreacion,
                              MensajeId = mensaje.MensajeId,
                              Remitente = personaje.Nombre,
                              PersonajeId = personajeId
                          }).OrderBy(m => m.Estado).ThenByDescending(m => m.FechaEnvio).ToListAsync();
        }

        public async Task<List<MensajeBandejaSalida>> GetMensajesEnviados(int personajeId)
        {
            var listaMensajes = await (from mensaje in _contexto.Mensajes
                                       where mensaje.RemitenteId == personajeId
                                       select new MensajeBandejaSalida
                                       {
                                           Asunto = mensaje.Asunto,
                                           EnviadoComo = mensaje.NombreParaMostrar,
                                           EsAnonimo = mensaje.EsAnonimo,
                                           FechaEnvio = mensaje.FechaCreacion,
                                           MensajeId = mensaje.MensajeId,
                                           PersonajeId = personajeId
                                       }).OrderByDescending(m => m.FechaEnvio).ToListAsync();

            foreach (MensajeBandejaSalida mensaje in listaMensajes)
            {
                mensaje.EnviadoA = String.Join("; ",
                                    (from destinatario in _contexto.DestinatariosMensaje
                                     join personaje in _contexto.Personajes on destinatario.DestinatarioId equals personaje.PersonajeId
                                     where destinatario.MensajeId == mensaje.MensajeId
                                     select personaje.Nombre
                                    ).ToList());
            }

            return listaMensajes;
        }

        public async Task<VistaMensaje> GetMensaje(int mensajeId, ApplicationUser usuario)
        {
            return await GetMensaje(mensajeId, 0, usuario);
        }

        public async Task<VistaMensaje> GetMensaje(int mensajeId, int personajeId, ApplicationUser usuario)
        {
            VistaMensaje vistaMensaje = null;

            if (PuedeVerMensaje(mensajeId, usuario))
            {
                vistaMensaje = await (from mensaje in _contexto.Mensajes
                                      join personaje in _contexto.Personajes on mensaje.RemitenteId equals personaje.PersonajeId
                                      where mensaje.MensajeId == mensajeId
                                      select new VistaMensaje
                                      {
                                          Asunto = mensaje.Asunto,
                                          Cuerpo = mensaje.Cuerpo,
                                          EsAnonimo = mensaje.EsAnonimo,
                                          FechaEnvio = mensaje.FechaCreacion,
                                          MensajeId = mensaje.MensajeId,
                                          Remitente = (mensaje.NombreParaMostrar == null || mensaje.NombreParaMostrar == string.Empty) ? personaje.Nombre : mensaje.NombreParaMostrar,
                                          RemitenteReal = personaje.Nombre
                                      }
                           ).FirstOrDefaultAsync();
                if (vistaMensaje != null)
                {
                    if (personajeId != 0)
                    {
                        await MarcarMensajeComoLeido(mensajeId, usuario.Id, personajeId);
                    }
                    else
                    {
                        await MarcarMensajeComoLeido(mensajeId, usuario);
                    }

                    if (usuario.Cuenta == TipoCuenta.Administrador || usuario.Cuenta == TipoCuenta.Narrador)
                    {
                        //para narradores y administradores, recupera todos los destinatarios
                        vistaMensaje.Destinatarios = String.Join("; ",
                                            (from destinatario in _contexto.DestinatariosMensaje
                                             join personaje in _contexto.Personajes on destinatario.DestinatarioId equals personaje.PersonajeId
                                             where destinatario.MensajeId == vistaMensaje.MensajeId
                                             select personaje.Nombre
                                            ).ToList());
                    }
                    else
                    {
                        //en caso de jugadores, recupera solo los destinatarios incluidos en el para
                        vistaMensaje.Destinatarios = String.Join("; ",
                                            (from destinatario in _contexto.DestinatariosMensaje
                                             join personaje in _contexto.Personajes on destinatario.DestinatarioId equals personaje.PersonajeId
                                             where destinatario.MensajeId == vistaMensaje.MensajeId && destinatario.TipoDestinatario == TipoDestinatario.Para
                                             select personaje.Nombre
                                            ).ToList());
                    }
                }
            }

            return vistaMensaje;
        }


        public async Task<bool> EnviarMensaje(Mensaje mensaje, List<string> para, List<string> copiaOculta)
        {
            bool resultado = true;

            mensaje.FechaCreacion = DateTime.Now;
            if (mensaje.EsAnonimo)
            {
                mensaje.NombreParaMostrar = string.Empty;
            }

            mensaje.Destinatarios = new List<DestinatarioMensaje>();
            DestinatarioMensaje destinatario;
            foreach (string destinatarioId in para)
            {
                destinatario = new DestinatarioMensaje();
                destinatario.DestinatarioId = Convert.ToInt32(destinatarioId);
                destinatario.EstadoMensaje = EstadoMensaje.SinLeer;
                destinatario.TipoDestinatario = TipoDestinatario.Para;
                mensaje.Destinatarios.Add(destinatario);
            }
            foreach (string destinatarioId in copiaOculta)
            {
                destinatario = new DestinatarioMensaje();
                destinatario.DestinatarioId = Convert.ToInt32(destinatarioId);
                destinatario.EstadoMensaje = EstadoMensaje.SinLeer;
                destinatario.TipoDestinatario = TipoDestinatario.CopiaOculta;
                mensaje.Destinatarios.Add(destinatario);
            }

            _contexto.Mensajes.Add(mensaje);
            await ConfirmarCambios();

            return resultado;
        }

        private bool PuedeVerMensaje(int mensajeId, ApplicationUser usuario)
        {
            if (usuario.Cuenta == TipoCuenta.Administrador || usuario.Cuenta == TipoCuenta.Narrador)
            {
                return true;
            }
            else
            {
                //podra ver el mensaje si es remitente o destinatario y no esta borrado
                bool esRemitente = false;
                bool esDestinatario = false;

                esDestinatario = (from destinatario in _contexto.DestinatariosMensaje
                                  join personaje in _contexto.Personajes on destinatario.DestinatarioId equals personaje.PersonajeId
                                  where destinatario.MensajeId == mensajeId && personaje.JugadorId == usuario.Id
                                  && destinatario.EstadoMensaje != EstadoMensaje.Borrado
                                  select destinatario.DestinatarioMensajeId).Count() > 0;

                if (!esDestinatario)
                {
                    esRemitente = (from mensaje in _contexto.Mensajes
                                   join personje in _contexto.Personajes on mensaje.RemitenteId equals personje.PersonajeId
                                   where personje.JugadorId == usuario.Id
                                   select mensaje.MensajeId).Count() > 0;
                }


                return esDestinatario || esRemitente;
            }
        }

        private async Task MarcarMensajeComoLeido(int mensajeId, ApplicationUser usuario)
        {
            DestinatarioMensaje destinatarioMensaje = (from destinatario in _contexto.DestinatariosMensaje
                                                       join personaje in _contexto.Personajes on destinatario.DestinatarioId equals personaje.PersonajeId
                                                       where destinatario.MensajeId == mensajeId && destinatario.EstadoMensaje == EstadoMensaje.SinLeer
                                                       && personaje.JugadorId == usuario.Id
                                                       select destinatario).FirstOrDefault();

            if (destinatarioMensaje != null)
            {
                destinatarioMensaje.EstadoMensaje = EstadoMensaje.Leido;
                Actualizar(destinatarioMensaje);
                await ConfirmarCambios();
            }
        }

        private async Task MarcarMensajeComoLeido(int mensajeId, string jugadorId, int personajeId)
        {
            DestinatarioMensaje destinatarioMensaje = (from destinatario in _contexto.DestinatariosMensaje
                                                       join personaje in _contexto.Personajes on destinatario.DestinatarioId equals personaje.PersonajeId
                                                       where destinatario.MensajeId == mensajeId && destinatario.EstadoMensaje == EstadoMensaje.SinLeer
                                                       && destinatario.DestinatarioId == personajeId && personaje.JugadorId == jugadorId
                                                       select destinatario).FirstOrDefault();

            if (destinatarioMensaje != null)
            {
                destinatarioMensaje.EstadoMensaje = EstadoMensaje.Leido;
                Actualizar(destinatarioMensaje);
                await ConfirmarCambios();
            }
        }
    }
}
