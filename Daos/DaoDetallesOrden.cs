using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Models;

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
                MySqlCommand cmd = new MySqlCommand( cmdStr,conn);
                cmd.Parameters.AddWithValue("@orden_id", orden_id);
                cmd.Parameters.AddWithValue("@id_sueter", objDetallesOrden.Id_Sueter);
                cmd.Parameters.AddWithValue("@precio", objDetallesOrden.Precio);
                cmd.Parameters.AddWithValue("@cantidad", objDetallesOrden.Cantidad);
                
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