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

        public bool Update(Sueter objSueter){
            bool done=false;
            MySqlConnection conn=Connention.Conn();

            try
            {
                String cmdStr=@"Update sueter set 
                no_sucursal=@no_sucursal,
                no_taller=@no_taller,
                talla=@talla,
                unidades=@unidades,
                precio=@precio,
                tipo=@tipo where id_sueter=@id_sueter";

                MySqlCommand cmd=new MySqlCommand(conn,cmdStr);
                cmd.Parameters.AddWithValue("@no_sucursal",objSueter.No_Sucursal);
                cmd.Parameters.AddWithValue("@no_taller",objSueter.No_Taller);
                cmd.Parameters.AddWithValue("@talla",objSueter.Talla);
                cmd.Parameters.AddWithValue("@unidades",objSueter.Unidades);
                cmd.Parameters.AddWithValue("@precio",objSueter.Precio);
                cmd.Parameters.AddWithValue("@tipo",objSueter.Tipo);
                cmd.Parameters.AddWithValue("id_sueter",objSueter.Id_Sueter);

                cmd.ExecuteNonQuery();
                
                done=true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                done=false;
            }finally{
                conn.Close();
                conn.Dispose();
            }

            return done;
        }

        public List<Sueter> Select(){
            List<Sueter> lstSueteres=null;
            MySqlConnection conn=Connention.Conn();

            try
            {
                String cmdStr="Select * from sueter";
                MySqlCommand cmd=new MySqlCommand(conn,cmdStr);
                MySqlDataReader dr = cmd.ExecuteReader();

                lstSueteres= new List<Sueter>();

                while(dr.Read()){
                    Sueter objSueter= new Sueter();
                    objSueter.Id_Sueter=int.Parse(dr["id_sueter"].ToString());
                    objSueter.No_Sucursal=int.Parse(dr["no_sucursal"].ToString());
                    objSueter.No_Taller=int.Parse(dr["no_taller"].ToString());
                    objSueter.Unidades=int.Parse(dr["unidades"].ToString());
                    objSueter.Tallas=Float.Parse(dr["tallas"].ToString());
                    objSueter.Precio=Float.Parse(dr["precio"].ToString());

                    lstSueteres.Add(objSueter);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                lstSueteres=null;
            }finally{
                conn.Close();
                conn.Dispose();
            }

            return lstSueteres;
        }

        public Sueter Select(int id_sueter){
            Sueter objSueter=null;
            MySqlConnection conn=Connention.Conn();

            try
            {
                String cmdStr="Select * from sueter where id_sueter=@id_sueter";
                MySqlCommand cmd=new MySqlCommand(conn,cmdStr);
                cmd.Parameters.AddWithValue("@id_sueter",id_sueter);
                MySqlDataReader dr = cmd.ExecuteReader();


                while(dr.Read()){
                    objSueter= new Sueter();
                    objSueter.Id_Sueter=int.Parse(dr["id_sueter"].ToString());
                    objSueter.No_Sucursal=int.Parse(dr["no_sucursal"].ToString());
                    objSueter.No_Taller=int.Parse(dr["no_taller"].ToString());
                    objSueter.Unidades=int.Parse(dr["unidades"].ToString());
                    objSueter.Tallas=Float.Parse(dr["tallas"].ToString());
                    objSueter.Precio=Float.Parse(dr["precio"].ToString());

                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                objSueter=null;
            }finally{
                conn.Close();
                conn.Dispose();
            }

            return objSueter;
        }

        public bool Delete(int id_sueter){
            bool done=false;
            MySqlConnection conn=Connention.Conn();

            try
            {
                String cmdStr="Delete from sueter where id_sueter=@id_sueter";
                MySqlCommand cmd= new MySqlCommand(conn,cmdStr);
                cmd.Parameters.AddWithValue("@id_sueter",id_sueter);
                cmd.ExecuteNonQuery();
                done=true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                done=false;
            }finally{
                conn.Close();
                conn.Dispose();
            }

            return done;
        }
    }
}