using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Vet.Herramientas.Web.Models;
using Vet.Herramientas.Web.Servicios;

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

		public IActionResult Listar()
		{
			return View("List", PropietarioService.ObtenerPropietarios());
		}

	}
}