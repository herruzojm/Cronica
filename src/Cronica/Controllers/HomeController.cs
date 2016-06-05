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
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Escribenos()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }        

        public IActionResult Error()
        {
            return View();
        }
    }
}
