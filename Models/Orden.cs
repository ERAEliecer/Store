using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Orden
    {
        public Orden()
        {
        }

        public Orden(int no_Trabajador, DateTime fecha_Orden)
        {
            
            No_Trabajador = no_Trabajador;
            Fecha_Orden = fecha_Orden;
        }

        public int Orden_Id { get; set; }
        public int No_Trabajador { get; set; }
        public DateTime Fecha_Orden { get; set; }

    }
}
