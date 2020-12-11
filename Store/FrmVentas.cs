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
	public partial class FrmVentas : Form
	{
		private DaoSueteres daoSueteres;
		private List<Sueter> lstSueteres = null;
		private List<DetallesOrden> lstDetallesOrden = new List<DetallesOrden>();
		private float total;
		public FrmVentas()
		{
			InitializeComponent();
			CargarSueteres();
			cboSueteres.SelectedIndex = 0;
			lblEmpleado.Text += "  " + FrmLogin.nombre;
			MessageBox.Show(DateTime.Now.Day+"");
			
		}

		private void CargarSueteres()
		{
			daoSueteres = new DaoSueteres();
			lstSueteres = daoSueteres.Select();

			foreach (Sueter sueter in lstSueteres)
			{
				cboSueteres.Items.Add(sueter.Tipo+" Talla: "+sueter.Talla);
			}
		}

		private void FrmVentas_Load(object sender, EventArgs e)
		{

		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			DetallesOrden detallesOrden = new DetallesOrden();
			detallesOrden.Id_Sueter = lstSueteres.ElementAt(cboSueteres.SelectedIndex).Id_Sueter;
			detallesOrden.Precio = lstSueteres.ElementAt(cboSueteres.SelectedIndex).Precio;
			int cantidad = int.Parse(txtCantidad.Text);
			detallesOrden.Cantidad = cantidad;
			lstDetallesOrden.Add(detallesOrden);

			
			float subtotal = lstSueteres.ElementAt(cboSueteres.SelectedIndex).Precio * cantidad;
			bool add = true;
			
			for (int i = 0; i < dgvVenta.Rows.Count-1; i++)
			{
				if (int.Parse(dgvVenta[0, i].Value.ToString()) == detallesOrden.Id_Sueter)
				{
						cantidad += int.Parse(dgvVenta[2, i].Value.ToString());
						detallesOrden.Cantidad = cantidad;
						dgvVenta[2, i].Value = cantidad+"";
						dgvVenta[4, i].Value = cantidad * detallesOrden.Precio+"";
						add = false;
				}
			}
			
			String[] addGrid = { detallesOrden.Id_Sueter+"", 
				lstSueteres.ElementAt(cboSueteres.SelectedIndex).Tipo,
				cantidad+"",
				lstSueteres.ElementAt(cboSueteres.SelectedIndex).Precio+"",
				subtotal+""
					};
			total += subtotal;

			lblTotal.Text = "";
			lblTotal.Text="Total: " + total;

			if (add) { dgvVenta.Rows.Add(addGrid); }

		}

		private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnVender_Click(object sender, EventArgs e)
		{
			Orden orden = new Orden(FrmLogin.no_trabajador, DateTime.Now);

			Transacciones transacciones = new Transacciones();

			if(transacciones.Compra(orden, lstDetallesOrden))
			{

				MessageBox.Show("Venta exitosa");
				 
			}
			else
			{
				MessageBox.Show("Error al realizar la venta");

			}

		}
	}
}
