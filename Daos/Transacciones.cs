using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;

namespace Daos
{
    public class Transacciones
    {
        public bool Compra(Orden objOrden,List<DetallesOrden> lstDetallesOrden){
            bool done=false;
            int orden_id=0;
            MySqlConnection conn = Connention.Conn();
            MySqlTransaction tr = null;

            try
            {
                tr=conn.BeginTransaction();
                DaoOrden objDaoOrden=new DaoOrden();
                orden_id=objDaoOrden.Insert(objOrden);

                foreach (DetallesOrden objDetalleOrden in lstDetallesOrden)
                {
                    DaoDetallesOrden objDaoDetallesOrden = new DaoDetallesOrden();
                    objDaoDetallesOrden.Insert(objDetalleOrden,orden_id);

                    DaoSueteres objDaoSueteres= new DaoSueteres();
                    Sueter objSueter=objDaoSueteres.Select(objDetalleOrden.Id_Sueter);
                    objSueter.ActualizarUnidades(objDetalleOrden.Cantidad);
                    objDaoSueteres.Update(objSueter);
                }

                tr.Commit(); 
                done =true;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                done=false;
                tr.Rollback();
            }finally
            {
                conn.Close();
                conn.Dispose();
            }

            return done;
        }
    }
}