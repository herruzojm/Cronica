using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Controllers
{
    public class RutasController : Controller
    {
        protected IActionResult AbrirPersonaje(int personajeId)
        {
            //return RedirectToAction("Edit", "Personajes", new { id = personajeId });
            return RedirectToRoute("AbrirPersonaje", new { id = personajeId });
        }
    }
}
