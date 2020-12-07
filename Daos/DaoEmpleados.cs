using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
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

		public List<Empleados> Select(){
			MySqlConnection conn=Connention.Conn();
			List<Empleados> lstEmpleados=null;
			
			try
			{
				String cmdStr="Select * from empleados";
				MySqlCommand cmd= new MySqlCommand(conn,cmdStr);
				MySqlDataReader dr=cmd.ExecuteReader();

				lstEmpleados=new List<Empleados>();

				while(dr.Read()){
					Empleados objEmpleado=new Empleados();
					objEmpleado.No_Trabajador=int.Parse(dr['no_trabajador'].ToString());
					objEmpleado.Nombre=dr["nombre"].ToString();
					objEmpleado.Apellido_Paterno=dr["apellido_paterno"].ToString();
					objEmpleado.Apellido_Materno=dr["apellido_materno"].ToString();
					objEmpleado.Telefono=dr["telefono"].ToString();
					objEmpleado.Admin=int.Parse(dr["admin"].ToString());
					lstEmpleados.Add(objEmpleado);
				}
			}
			catch(MySqlException ex)
			{
				lstEmpleados=null;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return lstEmpleados;

		}
		
		public Empleados Select(int no_trabajador){
			MySqlConnection conn=Connention.Conn();
			Empleados objEmpleado=null;
			
			try
			{
				String cmdStr="Select * from empleados where no_trabajador=@no_trabajador";
				MySqlCommand cmd= new MySqlCommand(conn,cmdStr);
				cmd.Parameters.AddWithValue("@no_trabajador",no_trabajador)
				MySqlDataReader dr=cmd.ExecuteReader();

				lstEmpleados=new List<Empleados>();

				while(dr.Read()){
					objEmpleado=new Empleados();
					objEmpleado.No_Trabajador=int.Parse(dr['no_trabajador'].ToString());
					objEmpleado.Nombre=dr["nombre"].ToString();
					objEmpleado.Apellido_Paterno=dr["apellido_paterno"].ToString();
					objEmpleado.Apellido_Materno=dr["apellido_materno"].ToString();
					objEmpleado.Telefono=dr["telefono"].ToString();
					objEmpleado.Admin=int.Parse(dr["admin"].ToString());
				}
			}
			catch(MySqlException ex)
			{
				objEmpleado=null;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return objEmpleado;

		}

		public bool Update(Empleados empleado)
		{
			bool done =false;
			MySqlConnection conn = Connention.Conn();

			try
			{
				String cmdStr = @"UPDATE empleados SET 
						nombre=@nombre,
						apellido_paterno=@apellido_paterno,
						apellido_materno=@apellido_materno,
						admin=@admin,
						password=sha2(@password,512),
						telefono=@telefono where no_trabajador=@no_trabajador";

				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);

				cmd.Parameters.AddWithValue("@no_trabajador", empleado.No_Trabajador);
				cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
				cmd.Parameters.AddWithValue("@apellido_paterno", empleado.Apellido_Paterno);
				cmd.Parameters.AddWithValue("@apellido_materno", empleado.Apellido_Materno);
				cmd.Parameters.AddWithValue("@admin", empleado.Admin);
				cmd.Parameters.AddWithValue("@password", empleado.Password);
				cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);

				cmd.ExecuteNonQuery();

				done = true;

			}
			catch (MySqlException ex)
			{
				done = false;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return done;
		}
	}
}
