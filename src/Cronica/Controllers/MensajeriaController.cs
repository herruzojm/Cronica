using Cronica.Modelos.Models;
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
            //ViewBag.ElegirPersonaje = new SelectList(await _servicioPersonajes.GetEnumeradoPersonajes(), "Id", "Descripcion");
            SelectList personajes = new SelectList(await _servicioPersonajes.GetEnumeradoPersonajes(), "Id", "Descripcion");
            personajes.Append(new SelectListItem() { Value = "", Text = "" });
            ViewBag.Personajes = personajes;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NuevoMensaje(Mensaje mensaje, List<string> Para, List<string> CopiaOculta)
        {
            //ViewBag.ElegirPersonaje = new SelectList(await _servicioPersonajes.GetEnumeradoPersonajes(), "Id", "Descripcion");            
            if (ModelState.IsValid)
            {
                if (Para.Count() > 0 || CopiaOculta.Count() > 0)
                {
                    if (await _servicioMensajeria.EnviarMensaje(mensaje, Para, CopiaOculta))
                    {
                        ViewBag.MensajeExito = "Mensaje enviado";
                        EnviarEmails(Para, CopiaOculta); //todo enviar de forma asincrona
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
            ViewBag.Personajes = personajes;
            return View(mensaje);
        }

        private void EnviarEmails(List<string> Para, List<string> CopiaOculta)
        {
            string jugadorEmail;
            foreach (string destinatarioId in Para)
            {
                jugadorEmail = _servicioUsuarios.GetEmailByPersonajeId(Convert.ToInt32(destinatarioId));
                _servicioEmail.EnviarNuevoMensaje(jugadorEmail);
            }
            foreach (string destinatarioId in CopiaOculta)
            {
                jugadorEmail = _servicioUsuarios.GetEmailByPersonajeId(Convert.ToInt32(destinatarioId));
                _servicioEmail.EnviarNuevoMensaje(jugadorEmail);
            }
        }

        public async Task<IActionResult> VerMensaje(int id, int personajeId)
        {
            ApplicationUser usuario = await _servicioUsuarios.GetUser(User);
            ViewBag.Usuario = usuario;
            VistaMensaje mensaje = await _servicioMensajeria.GetMensaje(id, personajeId, usuario);
            if (mensaje != null)
            {
                return View(mensaje);
            }
            else
            {
               return RedirectToAction("AccessDenied", "Account");
            }            
        }
    }
}
