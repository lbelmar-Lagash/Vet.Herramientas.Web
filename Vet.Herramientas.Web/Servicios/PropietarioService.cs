using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Herramientas.Web.Models;

namespace Vet.Herramientas.Web.Servicios
{
	public class PropietarioService
	{

		public static List<Propietario> ObtenerPropietarios()
		{
			var propietarios = new List<Propietario>();

			propietarios.Add(new Propietario("17538938-5", "Diego Calzadilla"));
			propietarios.Add(new Propietario("17511938-9", "Juan Campos"));
			propietarios.Add(new Propietario("12138938-7", "Diego Carrasco"));
			propietarios.Add(new Propietario("7138937-5", "Cristian Leal"));
			propietarios.Add(new Propietario("4534338-5", "Abel Soto"));

			return propietarios;
		}

		public static bool RegistrarPropietario(Propietario propietario)
		{
			return true;
		}
	}
}
