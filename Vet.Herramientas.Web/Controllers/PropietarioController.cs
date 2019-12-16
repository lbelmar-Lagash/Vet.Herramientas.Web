using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
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
			ViewData["comboboxPacientes"] = PacienteService.ObtenerPacientes();

			return View("Form");
		}

		public IActionResult Editar(string rut)
		{
			//buscar un registro
			var propietario = new Propietario();
			propietario.Nombre = "Editado";
			propietario.ApellidoMaterno = "Editado";
			propietario.ApellidoPaterno = "Editado";

			ViewData["comboboxPacientes"] = PacienteService.ObtenerPacientes();

			return View("Form", propietario);
		}

		[HttpPost]
		public IActionResult Ingresar(Propietario propietario)
		{
			using (var connection = new MySqlConnection("Server=localhost; Port=3306; Database = arauco-dev-db; Uid = root; Pwd =arauco-dev-db;  Uid = root; Pwd = arauco-password; "))
			{
				var parameters = new DynamicParameters();
				parameters.Add("@nombre", propietario.Nombre);
				parameters.Add("@apellido", propietario.ApellidoPaterno);
				parameters.Add("@apellidopaterno", propietario.ApellidoMaterno);

				connection.Execute(@"insert into Propietario values (@nombre, @apellido, @apellidopaterno)", parameters);
			}
			return View("Detalle", propietario);
		}

		public IActionResult Listar()
		{
			var propietarios = new List<Propietario>();

			using (var connection = new MySqlConnection("Server=localhost; Port=3306; Database = arauco-dev-db; Uid = root; Pwd =arauco-dev-db;  Uid = root; Pwd = arauco-password; "))
			{
				propietarios = connection.Query<Propietario>(@"select nombre, 
												apellido_paterno as ApellidoPaterno,
												apellido_materno as ApellidoMaterno
												from Propietario").ToList();
			}

			return View("List", propietarios);
		}

	}
}