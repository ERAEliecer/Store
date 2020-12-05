using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EmpleadoSucursal
    {
        public EmpleadoSucursal()
        {
        }

        public EmpleadoSucursal(int no_Trabajador, int no_Sucursal)
        {
            No_Trabajador = no_Trabajador;
            No_Sucursal = no_Sucursal;
        }

        public int No_Trabajador { get; set; }
        public int No_Sucursal { get; set; }
    }
}
