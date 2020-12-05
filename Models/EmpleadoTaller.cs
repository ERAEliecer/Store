using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EmpleadoTaller
    {
        public EmpleadoTaller() { }
        public EmpleadoTaller(int no_Trabajador, int no_Taller)
        {
            No_Trabajador = no_Trabajador;
            No_Taller = no_Taller;
        }

        public int No_Trabajador { get; set; }
        public int No_Taller { get; set; }

    }
}
