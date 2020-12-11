
namespace Store
{
	partial class FrmListarEmpleados
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dgvEmpleados = new System.Windows.Forms.DataGridView();
			this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.noTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellidoPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellidoMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvEmpleados
			// 
			this.dgvEmpleados.AllowUserToAddRows = false;
			this.dgvEmpleados.AllowUserToDeleteRows = false;
			this.dgvEmpleados.AutoGenerateColumns = false;
			this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noTrabajadorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoPaternoDataGridViewTextBoxColumn,
            this.apellidoMaternoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.adminDataGridViewCheckBoxColumn});
			this.dgvEmpleados.DataSource = this.empleadosBindingSource;
			this.dgvEmpleados.Location = new System.Drawing.Point(42, 72);
			this.dgvEmpleados.Name = "dgvEmpleados";
			this.dgvEmpleados.ReadOnly = true;
			this.dgvEmpleados.RowHeadersWidth = 51;
			this.dgvEmpleados.RowTemplate.Height = 24;
			this.dgvEmpleados.Size = new System.Drawing.Size(990, 281);
			this.dgvEmpleados.TabIndex = 0;
			// 
			// empleadosBindingSource
			// 
			this.empleadosBindingSource.DataSource = typeof(Models.Empleados);
			// 
			// noTrabajadorDataGridViewTextBoxColumn
			// 
			this.noTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "No_Trabajador";
			this.noTrabajadorDataGridViewTextBoxColumn.HeaderText = "No Trabajador";
			this.noTrabajadorDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.noTrabajadorDataGridViewTextBoxColumn.Name = "noTrabajadorDataGridViewTextBoxColumn";
			this.noTrabajadorDataGridViewTextBoxColumn.ReadOnly = true;
			this.noTrabajadorDataGridViewTextBoxColumn.Width = 40;
			// 
			// nombreDataGridViewTextBoxColumn
			// 
			this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
			this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
			this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
			this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
			this.nombreDataGridViewTextBoxColumn.Width = 125;
			// 
			// apellidoPaternoDataGridViewTextBoxColumn
			// 
			this.apellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Paterno";
			this.apellidoPaternoDataGridViewTextBoxColumn.HeaderText = "Apellido Paterno";
			this.apellidoPaternoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
			this.apellidoPaternoDataGridViewTextBoxColumn.ReadOnly = true;
			this.apellidoPaternoDataGridViewTextBoxColumn.Width = 125;
			// 
			// apellidoMaternoDataGridViewTextBoxColumn
			// 
			this.apellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Materno";
			this.apellidoMaternoDataGridViewTextBoxColumn.HeaderText = "Apellido Materno";
			this.apellidoMaternoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
			this.apellidoMaternoDataGridViewTextBoxColumn.ReadOnly = true;
			this.apellidoMaternoDataGridViewTextBoxColumn.Width = 125;
			// 
			// telefonoDataGridViewTextBoxColumn
			// 
			this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
			this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
			this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
			this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
			this.telefonoDataGridViewTextBoxColumn.Width = 125;
			// 
			// adminDataGridViewCheckBoxColumn
			// 
			this.adminDataGridViewCheckBoxColumn.DataPropertyName = "Admin";
			this.adminDataGridViewCheckBoxColumn.HeaderText = "Admin";
			this.adminDataGridViewCheckBoxColumn.MinimumWidth = 6;
			this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
			this.adminDataGridViewCheckBoxColumn.ReadOnly = true;
			this.adminDataGridViewCheckBoxColumn.Width = 125;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Lista de empleados";
			// 
			// FrmListarEmpleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1081, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvEmpleados);
			this.Name = "FrmListarEmpleados";
			this.Text = "FrmListarEmpleados";
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvEmpleados;
		private System.Windows.Forms.BindingSource empleadosBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn noTrabajadorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
		private System.Windows.Forms.Label label1;
	}
}