using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sucursales
    {

        public Sucursales() { }

        public Sucursales(int no_Sucursales, string direccion, string encargado)
        {
            No_Sucursales = no_Sucursales;
            Direccion = direccion;
            Encargado = encargado;
        }

        public int No_Sucursales { get; set; }
        public String Direccion { get; set; }
        public String Encargado { get; set; }
    }
}
