using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;

namespace Daos
{
    public class DaoEmpleadoTaller
    {
        public int Insert(EmpleadoTaller objEmpleadoTaller){
            int done=-1;
            MySqlConnection conn=Connention.Conn();

            try
            {
                String cmdStr=@"Insert into empleado_taller (no_trabajador,no_taller) 
                values (@no_trabajador,@no_taller)";
                MySqlCommand cmd= new MySqlCommand(conn,cmdStr);
                cmd.Parameters.AddWithValue("@no_trabajador",objEmpleadoTaller.No_Trabajador);
                cmd.Parameters.AddWithValue("@no_taller",objEmpleadoTaller.No_Taller);

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

        public bool Update(EmpleadoTaller objEmpleadoTaller){
            bool done=false;
            MySqlConnection conn=Connention.Conn();

            try
            {
                String cmdStr=@"Update empleado_taller set 
                no_trabajador=@no_trabajador,
                no_taller=@no_taller where no_trabajador=@no_trabajador";

                MySqlCommand cmd= new MySqlCommand(conn,cmdStr);
                cmd.Parameters.AddWithValue("@no_trabajador",objEmpleadoTaller.No_Trabajador);
                cmd.Parameters.AddWithValue("@no_sucursal",objEmpleadoTaller.No_Taller);

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
                String cmdStr=@"Delete from empleado_taller where no_trabajador=@no_trabajador";

                MySqlCommand cmd= new MySqlCommand(conn,cmdStr);
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

    }
}