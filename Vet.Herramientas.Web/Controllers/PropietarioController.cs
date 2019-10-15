using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vet.Herramientas.Web.Models;

namespace Vet.Herramientas.Web.Controllers
{
    public class PropietarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Crear()
		{
			return View("Form");
		}

		[HttpPost]
		public IActionResult Ingresar(Propietario propietario)
		{
			return View("Detalle", propietario);
		}
	}
}