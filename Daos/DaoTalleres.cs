using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;

namespace Daos{

    public class DaoTalleres{
        public List<Talleres> Select(){
            MySqlConnection conn = Connention.Conn();
            List<Talleres> lstTalleres = null;
            try
            {
                String cmdStr="Select * from talleres";
                MySqlCommand cmd = new MySqlCommand(cmdStr,conn);
                MySqlDataReader dr= cmd.ExecuteReader();
                lstTalleres=new List<Talleres>();
                
                while(dr.Read()){
                    Talleres objTaller= new Talleres();
                    objTaller.No_Taller=int.Parse(dr["no_taller"].ToString());
                    objTaller.Direccion=dr["direccion"].ToString();
                    objTaller.Encargado=dr["encargado"].ToString();
                    lstTalleres.Add(objTaller);
                }


            }
            catch (MySqlException ex)
            {
               Console.WriteLine(ex.ToString());
               lstTalleres=null;
            }
            finally{
                conn.Close();
                conn.Dispose();
            }
            return lstTalleres;
        }

        public int Insert(Talleres objTaller)
		{
            int done = -1;
            MySqlConnection conn= Connention.Conn();

			try
			{
                String cmdStr = "call InsertTaller(@Direccion,@Encargado)";
                MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
            
                cmd.Parameters.AddWithValue("@Direccion",objTaller.Direccion);
                cmd.Parameters.AddWithValue("@Encargado",objTaller.Encargado);

                cmd.ExecuteNonQuery();

                done = (int)cmd.LastInsertedId;
            }
			catch (MySqlException ex)
			{
                Console.WriteLine(ex.ToString());
                done = -1;
			}
			finally
			{
                conn.Close();
                conn.Dispose();
			}
            return done;
		}

        public bool Update(Talleres objTaller)
        {
            bool done = false;
            MySqlConnection conn = Connention.Conn();
            try
            {
                String cmdStr = "call UpdateTaller(@PDireccion,@PEncargado,@PNo_Taller)";
                MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
                cmd.Parameters.AddWithValue("@PDireccion", objTaller.Direccion);
                cmd.Parameters.AddWithValue("@PEncargado", objTaller.Encargado);
                cmd.Parameters.AddWithValue("@PNo_Taller", objTaller.No_Taller);

                cmd.ExecuteNonQuery();

                done = true;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                done = false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return done;
        }

        public bool Delete(int no_taller)
        {
            bool done = false;
            MySqlConnection conn = Connention.Conn();

            try
            {
                String cmdStr = "call DeleteTaller (@PNo_Taller)";
                MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
                cmd.Parameters.AddWithValue("@PNo_Taller", no_taller);

                cmd.ExecuteNonQuery();
                done = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                done = false;
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