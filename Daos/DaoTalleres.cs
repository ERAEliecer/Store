using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
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
    }
}