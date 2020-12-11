using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;

namespace Daos
{
    public class DaoEmpleadoSucursal
    {
        public int Insert(EmpleadoSucursal objEmpleadoSucursal){
            int done=-1;
            MySqlConnection conn=Connention.Conn();

            try
            {
                String cmdStr=@"Insert into empleado_sucursal (no_trabajador,no_sucursal) 
                values (@no_trabajador,@no_sucursal)";
                MySqlCommand cmd= new MySqlCommand(cmdStr,conn);
                cmd.Parameters.AddWithValue("@no_trabajador",objEmpleadoSucursal.No_Trabajador);
                cmd.Parameters.AddWithValue("@no_sucursal",objEmpleadoSucursal.No_Sucursal);

                cmd.ExecuteNonQuery();
                done=(int)cmd.LastInsertedId;
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.ToString());
                done=-1;

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return done;
        }

        public bool Update(EmpleadoSucursal objEmpleadoSucursal){
            bool done=false;
            MySqlConnection conn=Connention.Conn();

            try
            {
                String cmdStr=@"Update empleado_sucursal set 
                no_trabajador=@no_trabajador,
                no_sucursal=@no_sucursal where no_trabajador=@no_trabajador";

                MySqlCommand cmd= new MySqlCommand(cmdStr,conn);
                cmd.Parameters.AddWithValue("@no_trabajador",objEmpleadoSucursal.No_Trabajador);
                cmd.Parameters.AddWithValue("@no_sucursal",objEmpleadoSucursal.No_Sucursal);

                cmd.ExecuteNonQuery();
                done=true;
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.ToString());
                done=false;

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return done;
        }

         public bool Delete(int no_trabajador){
            bool done=false;
            MySqlConnection conn=Connention.Conn();

            try
            {
                String cmdStr=@"Delete from empleado_sucursal where no_trabajador=@no_trabajador";

                MySqlCommand cmd= new MySqlCommand(cmdStr,conn);
                cmd.Parameters.AddWithValue("@no_trabajador",no_trabajador);

                cmd.ExecuteNonQuery();
                done=true;
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.ToString());
                done=false;

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return done;
        }

        public EmpleadoSucursal Select(int no_trabajador) {
            EmpleadoSucursal empleado_sucursal = null;

            MySqlConnection conn = Connention.Conn();

			try
			{
                String cmdStr = "Select * from empleado_sucursal where no_trabajador=@no_trabajador";
                MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
                cmd.Parameters.AddWithValue("@no_trabajador", no_trabajador);

                MySqlDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
                    empleado_sucursal = new EmpleadoSucursal();
                    empleado_sucursal.No_Sucursal = int.Parse(dr["no_sucursal"].ToString());
                    empleado_sucursal.No_Trabajador= int.Parse(dr["no_trabajador"].ToString());

                }
            }
			catch (MySqlException ex)
			{
                Console.WriteLine(ex.ToString());
                empleado_sucursal = null;
            }
			finally
			{
                conn.Close();
                conn.Dispose();
			}

            return empleado_sucursal;
        }

    }
}