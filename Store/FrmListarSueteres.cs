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
	public partial class FrmListarSueteres : Form
	{
		public FrmListarSueteres()
		{
			InitializeComponent();
			CargarGrid();
		}

		private void CargarGrid()
		{
			List<Sueter> lstSueteres = new DaoSueteres().Select();
			dgvSueteres.DataSource = lstSueteres;
		}
	}
}
