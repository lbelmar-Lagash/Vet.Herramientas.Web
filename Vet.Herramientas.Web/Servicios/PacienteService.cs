using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Vet.Herramientas.Web.Models;

namespace Vet.Herramientas.Web.Servicios
{
	public class PacienteService
	{
		public static List<Paciente> ObtenerPacientes(string rutPropietario = null)
		{
			

			var pacientes = new List<Paciente>();
			pacientes.Add(new Paciente("Mishi","Gato","Desconocido","8763546478", new Propietario("17538938-5", "Diego Calzadilla")));
			pacientes.Add(new Paciente("Muñeca","Gato","Tuxedo","833546478", new Propietario("17511938-9", "Juan Campos")));
			pacientes.Add(new Paciente("Jack","Perro","Doberman","81163546478", new Propietario("12138938-7", "Diego Carrasco")));
			pacientes.Add(new Paciente("Laucha", "Perro", "Blanco", null, new Propietario("7138937-5", "Cristian Leal")));
			pacientes.Add(new Paciente("Chicho","Gato","Tuxedo","8763546478", new Propietario("4534338-5", "Abel Soto")));

			pacientes = pacientes.Where(p => string.IsNullOrWhiteSpace(rutPropietario) || p.Propietario.Rut == rutPropietario).ToList();
			return pacientes;
		}

		public static bool RegistrarPaciente(Paciente paciente)
		{
			return true;
		}
	}
}
