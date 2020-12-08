using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;

namespace Daos
{
    public class DaoSueteres
    {
        public int Insert(Sueter objSueter){
            int done=-1;
            MySqlConnection conn = Connention.Conn();

            try
            {
                String cmdStr= @"Insert into sueter (no_sucursal,no_taller,tipo,talla,unidades,precio) 
                values (@no_sucursal,@no_taller,@tipo,@talla,@unidades,@precio)";
                MySqlCommand cmd = new MySqlCommand(cmdStr,conn);
                cmd.Parameters.AddWithValue("@no_sucursal",objSueter.No_Sucursal);
                cmd.Parameters.AddWithValue("@no_taller",objSueter.No_Taller);
                cmd.Parameters.AddWithValue("@tipo",objSueter.Tipo);
                cmd.Parameters.AddWithValue("@precio",objSueter.Precio);
                cmd.Parameters.AddWithValue("@unidades",objSueter.Unidades);
                cmd.Parameters.AddWithValue("@talla",objSueter.Talla);

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