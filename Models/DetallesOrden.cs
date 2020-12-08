using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DetallesOrden
    {
        public DetallesOrden()
        {
        }

        public DetallesOrden(int id_Sueter, float precio, int cantidad)
        {
            Id_Sueter = id_Sueter;
            Precio = precio;
            Cantidad = cantidad;
        }

        public int Orden_Id { get; set; }
        public int Id_Sueter { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
