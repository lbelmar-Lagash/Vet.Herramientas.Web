using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Herramientas.Web.Models
{
	public class Examen
	{
		public string Url { get; set; }
		public Paciente Paciente { get; set; }
	}
}
