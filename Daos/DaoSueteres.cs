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
                cmd.Parameters.AddValueWith("@no_sucursal",objSueter.No_Sucursal);
                cmd.Parameters.AddValueWith("@no_taller",objSueter.No_Taller);
                cmd.Parameters.AddValueWith("@tipo",objSueter.Tipo);
                cmd.Parameters.AddValueWith("@precio",objSueter.Precio);
                cmd.Parameters.AddValueWith("@unidades",objSueter.Unidades;
                cmd.Parameters.AddValueWith("@talla",objSueter.Talla);

                cmd.ExecuteNonQuery();

                done=cmd.LastInsertedId();


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