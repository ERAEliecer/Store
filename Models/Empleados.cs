using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Empleados
    {
        public Empleados() { }
        public Empleados(int no_trabajador,
                         String nombre,
                         String apellido_paterno,
                         String apellido_materno,
                         String telefono,
                         String password,
                         bool admin)
        {

            No_Trabajador=no_trabajador;
            Nombre = nombre;
            Apellido_Materno = apellido_materno;
            Apellido_Paterno = apellido_paterno;
            Telefono = telefono;
            Password = password;
            Admin = admin;

        }
        public int No_Trabajador { get; set; }
        public String Nombre { get; set; }
        public String Apellido_Paterno { get; set; }
        public String Apellido_Materno { get; set; }
        public String Telefono { get; set; }
        public String Password { get; set; }
        public bool Admin { get; set; }
    }
}
