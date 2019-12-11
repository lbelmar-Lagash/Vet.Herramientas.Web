using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Vet.Herramientas.Web.Models;

namespace Vet.Herramientas.Web.Servicios
{
	public class PropietarioService
	{

		public static List<Propietario> ObtenerPropietarios()
		{
			using (var connection = new MySqlConnection(@"Server= localhost; Port = 3306; Database = arauco-dev-db;  Uid = root; Pwd = arauco-password;"))
			{
				var propietarios = connection.Query<Propietario>(@"select nombre, 
																	apellido_paterno as ApellidoPaterno, 
																	apellido_materno as ApellidoMaterno 
																	from Propietario").ToList();

				int cantidadPropietarios = connection.Query<int>(@"select count(*) from Propietario").First();

				return propietarios;
			}
		}

		public static bool RegistrarPropietario(Propietario propietario)
		{
			return true;
		}
	}
}
