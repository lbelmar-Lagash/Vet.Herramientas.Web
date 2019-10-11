using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Herramientas.Web.Models
{
	public class Medicamento
	{
		public string Compuesto { get; set; }
		public int Dosis { get; set; }
		public MedidaMedicamento Medida { get; set; }
		public List<string> NombresComerciales { get; set; }
	}

	public enum MedidaMedicamento
	{
		mg,
		gramos,
	}
}
