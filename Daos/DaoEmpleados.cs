using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;

namespace Daos
{
    public class DaoEmpleados
    {
		public int Insert(Empleados empleado)
		{
			int done = -1;
			MySqlConnection conn = Connention.Conn();

			try
			{
				String cmdStr = "INSERT INTO empleados(nombre,apellido_paterno,apellido_materno,admin,password,telefono)" +
					" VALUES(@nombre,@apellido_paterno,@apellido_materno,@admin,sha2(@password,512),@telefono)";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
				cmd.Parameters.AddWithValue("@apellido_paterno", empleado.Apellido_Paterno);
				cmd.Parameters.AddWithValue("@apellido_materno", empleado.Apellido_Materno);
				cmd.Parameters.AddWithValue("@admin", empleado.Admin);
				cmd.Parameters.AddWithValue("@password", empleado.Password);
				cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);

				cmd.ExecuteNonQuery();

				done = (int)cmd.LastInsertedId;

			}
			catch (MySqlException ex)
			{
				done = -1;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return done;
		}

		public bool Login(String nombre,String password)
        {
			Empleados empleado = new Empleados();
			bool login = false;
			MySqlConnection conn = Connention.Conn();

            try
            {
				String cdmStr = " select nombre from empleados where nombre = @nombre and password = sha2(@password, 256)";
				MySqlCommand cmd = new MySqlCommand(cdmStr, conn);
				cmd.Parameters.AddWithValue("@password", password);
				cmd.Parameters.AddWithValue("@nombre", nombre);


				MySqlDataReader dr = cmd.ExecuteReader();

				login = dr.HasRows;


			}
			catch (MySqlException ex)
            {
				Console.WriteLine(ex.ToString());
				login = false;
            }
            finally
            {
				conn.Close();
				conn.Dispose();
            }

			return login;

        }
	}
}
