using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Herramientas.Web.Models
{
	public class Propietario
	{
		public Propietario(string rut, string nombre)
		{
			Rut = rut;
			Nombre = nombre;
		}

		public string Rut { get; set; }
		public string Nombre { get; set; }
		public string Domicilio { get; set; }
		public string Telefono { get; set; }
	}
}
