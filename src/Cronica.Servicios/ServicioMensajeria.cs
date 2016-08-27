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
                          select new MensajeBandejaEntrada {
                              Asunto = mensaje.Asunto,
                              EnviadoComo = mensaje.NombreParaMostrar,
                              EsAnonimo = mensaje.EsAnonimo,
                              Estado = destinatario.EstadoMensaje,
                              FechaEnvio = mensaje.FechaCreacion,
                              MensajeId = mensaje.MensajeId,
                              Remitente = personaje.Nombre
                          }).OrderBy(m => m.Estado).ThenByDescending(m => m.FechaEnvio).ToListAsync();                
        }

        public async Task<List<Mensaje>> GetMensajesEnviados(int personajeId)
        {
            return await _contexto.Mensajes.Where(m => m.RemitenteId == personajeId).ToListAsync();
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
            foreach(string destinatarioId in para)
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
    }
}
