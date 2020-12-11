using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Daos;
using Models;
namespace Store
{
    public partial class FrmLogin : Form
    {
        public static int no_trabajador;
        public static String nombre;
        public FrmLogin()
        {
            InitializeComponent();
        }

		private void btnIniciarSesion_Click(object sender, EventArgs e)
		{
            DaoEmpleados daoEmpleados = new DaoEmpleados();
            String empleado = txtUsuario.Text;
            String password = txtPassword.Text;
            Empleados empleados = daoEmpleados.Login(empleado, password);

            if (empleados!=null)
			{
                no_trabajador = empleados.No_Trabajador;
                nombre = empleados.Nombre;
              

				if (empleados.Admin) {
                    
                    new FrmAdmin().ShowDialog();
				}
				else
				{
                    new FrmVentas().ShowDialog();
                }
			}
			else{
                MessageBox.Show("Credenciales incorrectas");

            }
		}
	}
}
