using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Talleres
    {

        public Talleres() { }

        public Talleres(int no_Taller, string direccion, string encargado)
        {
            No_Taller = no_Taller;
            Direccion = direccion;
            Encargado = encargado;
        }

        public int No_Taller { get; set; }
        public String Direccion { get; set; }
        public String Encargado { get; set; }

    }
}
