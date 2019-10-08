using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Herramientas.Web.Models
{
	public class Paciente
	{
		public string Nombre { get; set; }
		public string Especie { get; set; }
		public string Chip { get; set; }
		public string Raza { get; set; }
		public string Color { get; set; }
		public string Sexo { get; set; }
		public float Peso { get; set; }
		public DateTime Nacimiento { get; set; }
	}
}
