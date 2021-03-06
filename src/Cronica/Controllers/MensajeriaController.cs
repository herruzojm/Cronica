﻿using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.Mensajeria;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Controllers
{
    [Authorize(Policy = "Narrador")]
    public class MensajeriaController : RutasController
    {
        private IServicioMensajeria _servicioMensajeria;
        private IServicioPersonajes _servicioPersonajes;
        private IServicioUsuarios _servicioUsuarios;
        private IServicioEmail _servicioEmail;

        public MensajeriaController(IServicioMensajeria servicioMensajeria, IServicioPersonajes servicioPersonajes, 
            IServicioUsuarios servicioUsuarios, IServicioEmail servicioEmail)
        {
            _servicioMensajeria = servicioMensajeria;
            _servicioPersonajes = servicioPersonajes;
            _servicioUsuarios = servicioUsuarios;
            _servicioEmail = servicioEmail;
        }

        public async Task<IActionResult> Recibidos()
        {
            ViewBag.Personajes = new SelectList(await _servicioPersonajes.GetEnumeradoPersonajes(), "Id", "Descripcion");
            return View();
        }

        public IActionResult BandejaEntrada(int personajeId)
        {
            return ViewComponent(nameof(ViewComponents.BandejaEntrada), new { personajeId = personajeId, user = User });
        }

        public async Task<IActionResult> Enviados()
        {
            ViewBag.Personajes = new SelectList(await _servicioPersonajes.GetEnumeradoPersonajes(), "Id", "Descripcion");
            return View();
        }

        public IActionResult BandejaSalida(int personajeId)
        {            
            return ViewComponent(nameof(ViewComponents.BandejaSalida), new { personajeId = personajeId});
        }

        public IActionResult ComponenteNuevoMensaje(int personajeId)
        {
            ViewBag.Personajes = new SelectList(_servicioPersonajes.GetEnumeradoPersonajes().Result, "Id", "Descripcion");
            return ViewComponent(nameof(ViewComponents.NuevoMensaje), new { personajeId = personajeId });
        }

        public async Task<IActionResult> NuevoMensaje()
        {            
            SelectList personajes = new SelectList(await _servicioPersonajes.GetEnumeradoPersonajes(), "Id", "Descripcion");
            personajes.Append(new SelectListItem() { Value = "", Text = "" });
            ViewBag.PersonajesPara = personajes;
            ViewBag.PersonajesCopiaOculta = personajes;
            ViewBag.Titulo = "Nuevo Mensaje";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NuevoMensaje(Mensaje mensaje, List<string> Para, List<string> CopiaOculta)
        {
            if (ModelState.IsValid)
            {
                if (Para.Count() > 0 || CopiaOculta.Count() > 0)
                {
                    if (await _servicioMensajeria.EnviarMensaje(mensaje, Para, CopiaOculta))
                    {
                        ViewBag.MensajeExito = "Mensaje enviado";
                        _servicioMensajeria.EnviarEmails(Para, CopiaOculta); //todo enviar de forma asincrona
                        return View();
                    }
                }
                else
                {
                    ViewBag.MensajeError = $"Iiiioooo... sipote... selecciona a alguien pa' mandarle el mensaje, ¿no?";
                }                
            }
            else
            {
                ViewBag.MensajeError = $"Uppss... parece que los datos no son válidos";
            }
            SelectList personajes = new SelectList(await _servicioPersonajes.GetEnumeradoPersonajes(), "Id", "Descripcion");
            ViewBag.PersonajesPara = personajes;
            ViewBag.PersonajesCopiaOculta = personajes;
            ViewBag.Titulo = "Nuevo Mensaje";
            return View(mensaje);
        }

        public async Task<IActionResult> VerMensaje(int id, int personajeId)
        {
            ApplicationUser usuario = await _servicioUsuarios.GetUser(User);
            ViewBag.Usuario = usuario;            
            VistaMensaje mensaje = await _servicioMensajeria.GetVistaMensaje(id, personajeId, usuario);
            if (mensaje != null)
            {
                return View(mensaje);
            }
            else
            {
               return RedirectToAction("AccessDenied", "Account");
            }
        }

        public async Task<IActionResult> ResponderMensaje(int id)
        {
            ApplicationUser usuario = await _servicioUsuarios.GetUser(User);
            ViewBag.Titulo = "Responder Mensaje";
            Mensaje mensaje = await _servicioMensajeria.GetMensaje(id);
            if (mensaje != null)
            {
                mensaje.MensajeId = 0;
                if (!mensaje.Asunto.Contains(" Re.: "))
                {
                    mensaje.Asunto = " Re.: " + mensaje.Asunto;
                }
                mensaje.Cuerpo = "<p></p><p></p>[Enviador por " + mensaje.NombreAutentico + "]<p></p><blockquote>" +  mensaje.Cuerpo + "</blockquote>";
                SelectList personajesPara = new SelectList(await _servicioPersonajes.GetEnumeradoPersonajes(), "Id", "Descripcion");
                foreach (SelectListItem personajePara in personajesPara)
                {
                    if (mensaje.Destinatarios.Any(d => d.TipoDestinatario == TipoDestinatario.Para && d.DestinatarioId == Convert.ToInt32(personajePara.Value)))
                    {
                        personajePara.Selected = true;
                    }                    
                }
                SelectList personajesCopiaOculta = new SelectList(await _servicioPersonajes.GetEnumeradoPersonajes(), "Id", "Descripcion");
                foreach (SelectListItem personajeCopiaOculta in personajesCopiaOculta)
                {
                    if (mensaje.Destinatarios.Any(d => d.TipoDestinatario == TipoDestinatario.CopiaOculta && d.DestinatarioId == Convert.ToInt32(personajeCopiaOculta.Value)))
                    {
                        personajeCopiaOculta.Selected = true;
                    }
                }
                ViewBag.PersonajesPara = personajesPara;
                ViewBag.PersonajesCopiaOculta = personajesCopiaOculta;
                return View("NuevoMensaje", mensaje);
            }
            else
            {
                return RedirectToAction("AccessDenied", "Account");
            }
        }
    }
}
