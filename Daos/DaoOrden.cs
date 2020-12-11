using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Models;

namespace Daos
{
    public class DaoOrden
    {
        public int Insert(Orden objOrden)
        {
            int done = -1;
            MySqlConnection conn= Connention.Conn();

            try
            {
                String cmdStr=@"Insert into orden (no_trabajador,fecha_orden) 
                values (@no_trabajador,@fecha_orden)";
                MySqlCommand cmd= new MySqlCommand(cmdStr,conn);
                cmd.Parameters.AddWithValue("@no_trabajador",objOrden.No_Trabajador);
                String fecha_orden =objOrden.Fecha_Orden.Year+"-"+ objOrden.Fecha_Orden.Month + "-"+
                    objOrden.Fecha_Orden.Day;
                cmd.Parameters.AddWithValue("@fecha_orden",fecha_orden);

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
    }
}