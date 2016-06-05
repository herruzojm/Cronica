using Microsoft.AspNetCore.Mvc;
using System;

namespace Cronica.Controllers
{
    public class SistemaController : Controller
    {
        public IActionResult Sistema()
        {
            return View();
        }
    }

}
