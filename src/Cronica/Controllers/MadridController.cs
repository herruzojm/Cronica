using Microsoft.AspNet.Mvc;
using System;

namespace Cronica.Controllers
{
    public class MadridController : Controller
    {
        public IActionResult Historia()
        {            
            return View();
        }

        public IActionResult CarasConocidas()
        {
            return View();
        }
    }

}
