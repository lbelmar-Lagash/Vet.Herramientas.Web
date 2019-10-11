using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Vet.Herramientas.Web.Models
{
	public class Cita
	{
		public DateTime Fecha { get; set; }
		public Paciente Paciente { get; set; }
		public EstadoAtencion Estado { get; set; }
		public string MotivoConsulta { get; set; }
	}

	public enum EstadoAtencion
	{
        [Description("En espera")]
		EnEspera,
        [Description("Atención Realizada")]
		Realizada,
        [Description("Confirma Atención")]
		Confirmado,
        [Description("Confirmación Pendiente")]
		PorConfirmar
	}
}
