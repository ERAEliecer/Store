using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                String cmdStr=@"Insert into order (no_trabajador,fecha_orden) 
                values (@no_trabajador,@fecha_orden)";
                MySqlCommand cmd= new MySqlCommand(conn,cmdStr);
                cmd.Parameters.AddWithValue("@no_trabajador",objOrden.No_Trabajador);
                cmd.Parameters.AddWithValue("@fecha_orden",objOrden.Fecha_Orden);

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