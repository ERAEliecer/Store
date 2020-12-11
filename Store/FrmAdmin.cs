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
	public partial class FrmAdmin : Form
	{
		private DaoEmpleados daoEmpleados;
		private Empleados empleado;
		private Sueter sueter;
		private Sucursales sucursal;
		private Talleres taller;
		private EmpleadoSucursal empleado_sucursal;
		private EmpleadoTaller empleado_taller;
		private DaoSueteres daoSueteres = new DaoSueteres();
		private List<Sucursales> lstSucursales;
		private List<Talleres> lstTalleres;
		private int indexSucursal=-1;
		private int indexTaller = -1;

		public FrmAdmin()
		{
			InitializeComponent();
			ckbTaller.Checked = true;
			CargarCombosSueteres();
			CargarGridSucursal();
			CargarGridTaller();
			lblBienvenido.Text += " " + FrmLogin.nombre;
		}

		private void LimpiarSucursales()
		{
			txtSuDireccion.Text = "";
			txtSuEncargado.Text = "";
		}
		private void LimpiarTalleres()
		{
			txtTDireccion.Text = "";
			txtTEncargado.Text = "";
		}
		private void CargarGridSucursal()
		{
			dgvSucursales.DataSource = lstSucursales;
		}

		private void CargarGridTaller()
		{
			dgvTalleres.DataSource = lstTalleres;
		}


		private void LimpiarSueteres()
		{
			txtSAnadir.Text = "";
			txtSPrecio.Text = "";
			txtSAnadir.Text = "";
			txtSTipo.Text = "";
			txtSTalla.Text = "";
			txtSUnidades.Text = "";
			cboSSucursal.SelectedIndex = 0;
			cboSTaller.SelectedIndex = 0;
		}

		private void Limpiar()
		{
			txtNombre.Text = "";
			txtApellidoMaterno.Text = "";
			txtApellidoPaterno.Text = "";
			txtNo_Sucursal.Text = "";
			txtNo_Taller.Text = "";
			ckbTaller.Checked = true;
			ckbAdmin.Checked = false;
		}

		private void CargarCombosSueteres()
		{
			lstSucursales = new DaoSucursales().Select();
			lstTalleres = new DaoTalleres().Select();
			cboSSucursal.Items.Clear();
			cboSTaller.Items.Clear();
			foreach (Sucursales sucursal in lstSucursales)
			{
				cboSSucursal.Items.Add("Sucursal: "+sucursal.No_Sucursal + 
					" Encargado: " + sucursal.Encargado);
			}

			foreach (Talleres taller in lstTalleres)
			{
				cboSTaller.Items.Add("Taller: " + taller.No_Taller +
					" Encargado: " + taller.Encargado);
			}

			cboSSucursal.SelectedIndex = 0;
			cboSTaller.SelectedIndex = 0;
		}
		private void btnListar_Click(object sender, EventArgs e)
		{
			new FrmListarEmpleados().Show();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			daoEmpleados = new DaoEmpleados();
			String nombre = txtNombre.Text;
			String apellido_materno = txtApellidoMaterno.Text;
			String apellido_paterno = txtApellidoPaterno.Text;
			String telefono = txtTelefono.Text;
			String password = txtPassword.Text;
			bool admin = ckbAdmin.Checked;

			empleado = new Empleados();
			empleado.Nombre = nombre;
			empleado.Apellido_Paterno = apellido_paterno;
			empleado.Apellido_Materno = apellido_materno;
			empleado.Telefono = telefono;
			empleado.Password = password;
			empleado.Admin = admin;
			int em = daoEmpleados.Insert(empleado);
			if (em > 0) {

				if (ckbTaller.Checked)
				{
					int no_taller = int.Parse(txtNo_Taller.Text);
					
					new DaoEmpleadoTaller().Insert(new EmpleadoTaller(em,no_taller));
				}
				else
				{
					int no_sucursal = int.Parse(txtNo_Sucursal.Text);

					new DaoEmpleadoSucursal().Insert(new EmpleadoSucursal(em,no_sucursal));
				}
				MessageBox.Show("Registrado");
				Limpiar();
			}
			else
			{
				MessageBox.Show("Error al registrar");

			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			int no_trabajador = int.Parse(txtBuscar.Text);
			btnEditar.Enabled = true;
			btnEliminar.Enabled = true;
			btnGuardar.Enabled = false;

			empleado = new DaoEmpleados().Select(no_trabajador);

			txtNombre.Text = empleado.Nombre;
			txtApellidoMaterno.Text = empleado.Apellido_Materno;
			txtApellidoPaterno.Text = empleado.Apellido_Paterno;
			txtTelefono.Text = empleado.Telefono;
			ckbAdmin.Checked = empleado.Admin;

			if (!empleado.Admin)
			{
				empleado_taller = new DaoEmpleadoTaller().Select(no_trabajador);
				ckbTaller.Enabled = false;
				if (empleado_taller != null)
				{
					ckbTaller.Checked = true;
					txtNo_Taller.Text = empleado_taller.No_Taller+"";
				}
				else
				{
					empleado_sucursal = new DaoEmpleadoSucursal().Select(no_trabajador);
					ckbTaller.Checked = false;
					txtNo_Sucursal.Text = empleado_sucursal.No_Sucursal + "";
				}
			}

		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			daoEmpleados = new DaoEmpleados();
			btnEditar.Enabled = false;
			btnGuardar.Enabled  = true;
			ckbTaller.Enabled = true;
			String nombre = txtNombre.Text;
			String apellido_materno = txtApellidoMaterno.Text;
			String apellido_paterno = txtApellidoPaterno.Text;
			String telefono = txtTelefono.Text;
			String password = txtPassword.Text;
			bool admin = ckbAdmin.Checked;
			int no_trabajador = int.Parse(txtBuscar.Text);
			empleado = new Empleados();
			empleado.No_Trabajador = no_trabajador;
			empleado.Nombre = nombre;
			empleado.Apellido_Paterno = apellido_paterno;
			empleado.Apellido_Materno = apellido_materno;
			empleado.Telefono = telefono;
			empleado.Password = password;
			empleado.Admin = admin;
			ckbTaller.Enabled = true;
			if (daoEmpleados.Update(empleado))
			{
				if (ckbTaller.Checked)
				{
					int no_taller = int.Parse(txtNo_Taller.Text);

					new DaoEmpleadoTaller().Update(new EmpleadoTaller(no_trabajador, no_taller));
				}
				else
				{
					int no_sucursal = int.Parse(txtNo_Sucursal.Text);

					new DaoEmpleadoSucursal().Update(new EmpleadoSucursal(no_trabajador, no_sucursal));
				}
					MessageBox.Show("Actualizado");
				Limpiar();
			}
			else
			{
				MessageBox.Show("Error al actualizar");

			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;
			int no_trabajador = int.Parse(txtBuscar.Text);

			if (new DaoEmpleados().Delete(no_trabajador)){
				if (!new DaoEmpleadoSucursal().Delete(no_trabajador))
				{
					new DaoEmpleadoTaller().Delete(no_trabajador);
				}
				MessageBox.Show("Eliminado");
			}
			else{
				MessageBox.Show("Error al eliminar");

			}

			Limpiar();
		}

		private void ckbTaller_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbTaller.Checked)
			{
				txtNo_Taller.Enabled=true;
				txtNo_Sucursal.Enabled = false;
			}
			else
			{
				txtNo_Sucursal.Enabled = true;
				txtNo_Taller.Enabled = false;
			}
		}

		private void ckbAdmin_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbAdmin.Checked)
			{
				ckbTaller.Enabled = false; 
				txtNo_Sucursal.Enabled = false;
				txtNo_Taller.Enabled = false;
			}
			else
			{
				ckbTaller.Enabled = true;
				txtNo_Taller.Enabled = true;
			}
		}

		private void btnSGuardar_Click(object sender, EventArgs e)
		{
			

			int no_taller = lstTalleres.ElementAt(cboSTaller.SelectedIndex).No_Taller;
			int no_sucursal = lstSucursales.ElementAt(cboSSucursal.SelectedIndex).No_Sucursal;
			String tipo = txtSTipo.Text;
			float talla = float.Parse(txtSTalla.Text);
			float precio = float.Parse(txtSPrecio.Text);
			int unidades = int.Parse(txtSUnidades.Text);

			Sueter sueter = new Sueter();
			sueter.No_Sucursal = no_sucursal;
			sueter.No_Taller = no_taller;
			sueter.Tipo = tipo;
			sueter.Talla = talla;
			sueter.Precio = precio;
			sueter.Unidades = unidades;

			if (daoSueteres.Insert(sueter)>0)
			{
				MessageBox.Show("Sueter agregado correctamente");
				LimpiarSueteres();
			}
			else
			{
				MessageBox.Show("Error");
			}


		}

		private void btnSBuscar_Click(object sender, EventArgs e)
		{
			int id_sueter = int.Parse(txtSBuscar.Text);
	
			sueter = daoSueteres.Select(id_sueter);

			if (sueter!=null)
			{
				btnSGuardar.Enabled = false;
				btnSEditar.Enabled = true;
				btnSEliminar.Enabled = true;

				txtSUnidades.Text = sueter.Unidades+"";
				txtSUnidades.Enabled = false;
				txtSAnadir.Enabled = true;

				txtSTalla.Text = sueter.Talla + "";
				txtSPrecio.Text = sueter.Precio + "";
				txtSTipo.Text = sueter.Tipo;

				for (int i = 0; i < lstSucursales.Count; i++)
				{
					if (lstSucursales.ElementAt(i).No_Sucursal==sueter.No_Sucursal)
					{
						cboSSucursal.SelectedIndex = i;
					}
				}

				for (int i = 0; i < lstTalleres.Count; i++)
				{
					if (lstTalleres.ElementAt(i).No_Taller == sueter.No_Taller)
					{
						cboSTaller.SelectedIndex = i;
					}
				}



			}


		}

		private void btnSListar_Click(object sender, EventArgs e)
		{
			new FrmListarSueteres().Show();
		}

		private void btnSEditar_Click(object sender, EventArgs e)
		{
			btnSGuardar.Enabled = true;
			btnSEditar.Enabled = false;
			int no_taller = lstTalleres.ElementAt(cboSTaller.SelectedIndex).No_Taller;
			int no_sucursal = lstSucursales.ElementAt(cboSSucursal.SelectedIndex).No_Sucursal;
			int id_sueter = int.Parse(txtSBuscar.Text);

			String tipo = txtSTipo.Text;
			float talla = float.Parse(txtSTalla.Text);
			float precio = float.Parse(txtSPrecio.Text);
			int agregar = int.Parse(txtSAnadir.Text);

			
			sueter.No_Sucursal = no_sucursal;
			sueter.No_Taller = no_taller;
			sueter.Tipo = tipo;
			sueter.Talla = talla;
			sueter.Precio = precio;
			sueter.Unidades += agregar;
			sueter.Id_Sueter = id_sueter;

			if (daoSueteres.Update(sueter))
			{
				MessageBox.Show("Sueter editado correctamente");
				LimpiarSueteres();
				txtSAnadir.Enabled = false;
				txtSUnidades.Enabled = true;
			}
			else
			{
				MessageBox.Show("Error");
			}
		}

		private void btnSEliminar_Click(object sender, EventArgs e)
		{
			int id_sueter = int.Parse(txtSBuscar.Text);
			btnSEliminar.Enabled = false;
			btnSGuardar.Enabled = true;

			if (daoSueteres.Delete(id_sueter))
			{
				txtSAnadir.Enabled = false;
				txtSUnidades.Enabled = true;
				MessageBox.Show("Eliminado Correctamente");
			}
			else
			{
				MessageBox.Show("Error");
			}

		}

		private void dgvSucursales_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			indexSucursal=dgvSucursales.CurrentCell.RowIndex;
		}

		private void btnSuGuardar_Click(object sender, EventArgs e)
		{
			String direccion = txtSuDireccion.Text;
			String encargado = txtSuEncargado.Text;

			Sucursales sucursal = new Sucursales();
			sucursal.Direccion = direccion;
			sucursal.Encargado = encargado;

			if (new DaoSucursales().Insert(sucursal)>0) {
				MessageBox.Show("Sucursal agregada correctamente");
				CargarCombosSueteres();
				CargarGridSucursal();
				LimpiarSucursales();
			}
			else
			{
				MessageBox.Show("Error");

			}
		}

		private void btnSuEditar_Click(object sender, EventArgs e)
		{
			
			
			if (indexSucursal > -1)
			{
				

				if (!btnSuEditar.Text.Equals("Editar"))
				{
					sucursal.Direccion = txtSuDireccion.Text;
					sucursal.Encargado = txtSuEncargado.Text;

					if (new DaoSucursales().Update(sucursal)) {
						MessageBox.Show("Actualizao correctamente");
						CargarCombosSueteres();
						CargarGridSucursal();
						btnGuardar.Enabled = true;
						LimpiarSucursales();
						btnSuGuardar.Enabled = true;
						btnSuEditar.Text = "Editar";
					}
					else
					{
						MessageBox.Show("Error");
					}
				}
				else
				{
					btnSuGuardar.Enabled = false;
					sucursal = lstSucursales.ElementAt(indexSucursal);
					txtSuDireccion.Text = sucursal.Direccion;
					txtSuEncargado.Text = sucursal.Encargado;
					btnSuEditar.Text = "Actualizar";
					
				}
			}
			else
			{
				MessageBox.Show("Seleccione un elemento de la tabla");
			}
		}

		private void btnSuEliminar_Click(object sender, EventArgs e)
		{
			if (indexSucursal > -1)
			{
				if (new DaoSucursales().Delete(lstSucursales.ElementAt(indexSucursal).No_Sucursal))
				{
					CargarCombosSueteres();
					CargarGridSucursal();
					MessageBox.Show("Eliminado correctamente");
				}
				else
				{
					MessageBox.Show("Error");

				}
			}
			else
			{
				MessageBox.Show("Seleccione un elemento de la tabla");
			}
		}

		private void dgvTalleres_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			indexTaller = dgvTalleres.CurrentCell.RowIndex;
		}

		private void btnTGuardar_Click(object sender, EventArgs e)
		{
			String direccion = txtTDireccion.Text;
			String encargado = txtTEncargado.Text;

			Talleres taller = new Talleres();
			taller.Direccion = direccion;
			taller.Encargado = encargado;

			if (new DaoTalleres().Insert(taller) >= 0)
			{
				MessageBox.Show("Taller agregado correctamente");
				CargarCombosSueteres();
				CargarGridTaller();
				LimpiarTalleres();
			}
			else
			{
				MessageBox.Show("Error");

			}
		}

		private void btnTEditar_Click(object sender, EventArgs e)
		{
			
			if (indexTaller > -1)
			{


				if (!btnTEditar.Text.Equals("Editar"))
				{
					taller.Direccion = txtTDireccion.Text;
					taller.Encargado = txtTEncargado.Text;

					if (new DaoTalleres().Update(taller))
					{
						MessageBox.Show("Actualizao correctamente");
						CargarCombosSueteres();
						CargarGridTaller();
						LimpiarTalleres();
						btnTGuardar.Enabled = true;
						btnTEditar.Text = "Editar";
					}
					else
					{
						MessageBox.Show("Error");
					}
				}
				else
				{
					btnTGuardar.Enabled = false;
					taller = lstTalleres.ElementAt(indexTaller);
					txtTDireccion.Text = taller.Direccion;
					txtTEncargado.Text = taller.Encargado;
					btnTEditar.Text = "Actualizar";

				}
			}
			else
			{
				MessageBox.Show("Seleccione un elemento de la tabla");
			}
		}

		private void btnTEliminar_Click(object sender, EventArgs e)
		{
			if (indexTaller > -1)
			{
				if (new DaoTalleres().Delete(lstTalleres.ElementAt(indexTaller).No_Taller))
				{
					CargarCombosSueteres();
					CargarGridTaller();
					MessageBox.Show("Eliminado correctamente");
				}
				else
				{
					MessageBox.Show("Error");

				}
			}
			else
			{
				MessageBox.Show("Seleccione un elemento de la tabla");
			}
		}
	}
	
}
