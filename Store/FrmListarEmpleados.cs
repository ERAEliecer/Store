using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Daos;

namespace Store
{
	public partial class FrmListarEmpleados : Form
	{
		public FrmListarEmpleados()
		{
			InitializeComponent();
			CargarEmpleados();
		}

		private void CargarEmpleados()
		{
			List<Empleados> lstEmpleados = new DaoEmpleados().Select();
			dgvEmpleados.DataSource = lstEmpleados;
		}
	}
}
