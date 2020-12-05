using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sueter
    {
        public Sueter()
        {
        }

        public Sueter(int id_Sueter, int no_Sucursal, int no_Taller, string tipo, float talla, int unidades, float precio)
        {
            Id_Sueter = id_Sueter;
            No_Sucursal = no_Sucursal;
            No_Taller = no_Taller;
            Tipo = tipo;
            Talla = talla;
            Unidades = unidades;
            Precio = precio;
        }

        public int Id_Sueter { get; set; }
        public int No_Sucursal { get; set; }
        public int No_Taller { get; set; }
        public String Tipo { get; set; }
        public float Talla { get; set; }
        public int Unidades { get; set; }
        public float Precio { get; set; }
    }
}
