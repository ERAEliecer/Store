using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daos
{
    public class DaoDetallesOrden
    {
        public int Insert(DetallesOrden objDetallesOrden,int orden_id)
        {
            int done = -1;
            MySqlConnection conn= Connention.Conn();

            try
            {
                String cmdStr = @"Insert into detalles_orden(orden_id,id_sueter,precio,cantidad)  
                    values(@orden_id,@id_sueter,@precio,@cantidad)";
                MySqlCommand cmd = new MySqlCommand(conn, cmdStr);
                cmd.AddWithValue("@orden_id", orden_id);
                cmd.AddWithValue("@id_sueter", objDetallesOrden.Id_Sueter);
                cmd.AddWithValue("@precio", objDetallesOrden.Precio);
                cmd.AddWithValue("@cantidad", objDetallesOrden.Cantidad);
                
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