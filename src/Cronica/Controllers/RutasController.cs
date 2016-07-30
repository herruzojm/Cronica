using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Controllers
{
    public class RutasController : Controller
    {


        protected IActionResult VistaMiPersonaje()
        {
            return RedirectToRoute("MiPersonaje");
        }

        protected IActionResult AbrirPersonaje(int personajeId)
        {
            return RedirectToRoute("AbrirPersonaje", new { id = personajeId });
        }

        protected IActionResult AbrirPostPartida(int postPartidaId)
        {
            return RedirectToRoute("AbrirPostPartida", new { id = postPartidaId });
        }

    }
}
