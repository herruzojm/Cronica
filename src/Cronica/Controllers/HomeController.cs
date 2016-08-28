using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cronica.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult QuienesSomos()
        {
            return View();
        }

        public IActionResult Escribenos()
        {
            return View();
        }

        public IActionResult NotaMensajeria()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
