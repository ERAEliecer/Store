using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;

namespace Daos
{
    public class DaoSucursales
    {
        public List<Sucursales> Select()
        {
            MySqlConnection conn = Connention.Conn();
            List<Sucursales> lstSucursales = null;
            try
            {
                String cmdStr = "Select * from sucursales";
                MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                lstSucursales = new List<Sucursales>();
                while (dr.Read())
                {
                    Sucursales objSucursal = new Sucursales();
                    objSucursal.No_Sucursal = int.Parse(dr["no_sucursal"].ToString());
                    objSucursal.Direccion = dr["direccion"].ToString();
                    objSucursal.Encargado = dr["encargado"].ToString();
                    lstSucursales.Add(objSucursal);
                }


            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                lstSucursales = null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return lstSucursales;
        }

        public Sucursales Select(int no_sucursal){
            MySqlConnection conn=Connention.Conn();
            Sucursales objSucursal=null;

            try
            {
                String cmdStr="Select * from sucursales where no_sucursal=@no_sucursal";
                MySqlCommand cmd= new MySqlCommand(cmdStr,conn);
                cmd.Parameters.AddWithValue("@no_sucursal",no_sucursal);
                MySqlDataReader dr= cmd.ExecuteReader();

                while(dr.Read())
                {
                    objSucursal= new Sucursales();
                    objSucursal.No_Sucursal=int.Parse(dr["no_sucursal"].ToString());
                    objSucursal.Direccion=dr["direccion"].ToString();
                    objSucursal.Encargado=dr["encargado"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                objSucursal=null;
            }finally{
                conn.Close();
                conn.Dispose();
            }

            return objSucursal;
        }

        public int Insert(Sucursales objSucursal){
            
            int done=-1;
            MySqlConnection conn= Connention.Conn();

            try
            {
                String cmdStr= @"Insert into sucursales(direccion,encargado) 
                 values (@direccion,@encargado)";
                MySqlCommand cmd= new MySqlCommand(cmdStr,conn);
                cmd.Parameters.AddWithValue("@direccion", objSucursal.Direccion);
                cmd.Parameters.AddWithValue("@encargado",objSucursal.Encargado);

                cmd.ExecuteNonQuery();
                done = (int)cmd.LastInsertedId;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                done=-1;
            }finally
            {
                conn.Close();
                conn.Dispose();
            }

            return done;
        }

        public bool Update(Sucursales objSucursal){
            bool done=false;
            MySqlConnection conn = Connention.Conn();
            try
            {
                String cmdStr= @"Update sucursales set 
                direccion=@direccion,
                encargado=@encargado where no_sucursal=@no_sucursal";
                MySqlCommand cmd=new MySqlCommand(cmdStr,conn);
                cmd.Parameters.AddWithValue("@direccion", objSucursal.Direccion);
                cmd.Parameters.AddWithValue("@encargado",objSucursal.Encargado);

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

        public bool Delete(int no_sucursal){
            bool done=false;
            MySqlConnection conn=Connention.Conn();

            try
            {
                String cmdStr="Delete from sucursales where no_sucursal=@no_sucursal";
                MySqlCommand cmd = new MySqlCommand(cmdStr,conn);
                cmd.Parameters.AddWithValue("@no_sucursal",no_sucursal);

                cmd.ExecuteNonQuery();
                done=true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                done=false;
            } finally{
                conn.Close();
                conn.Dispose();
            }

            return done;
        }
    }
}