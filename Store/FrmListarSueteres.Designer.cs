
namespace Store
{
	partial class FrmListarSueteres
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
			this.dgvSueteres = new System.Windows.Forms.DataGridView();
			this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sueterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.idSueterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noTallerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvSueteres)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sueterBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSueteres
			// 
			this.dgvSueteres.AllowUserToAddRows = false;
			this.dgvSueteres.AllowUserToDeleteRows = false;
			this.dgvSueteres.AutoGenerateColumns = false;
			this.dgvSueteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSueteres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSueterDataGridViewTextBoxColumn,
            this.noSucursalDataGridViewTextBoxColumn,
            this.noTallerDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.tallaDataGridViewTextBoxColumn,
            this.unidadesDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
			this.dgvSueteres.DataSource = this.sueterBindingSource;
			this.dgvSueteres.Location = new System.Drawing.Point(17, 105);
			this.dgvSueteres.Name = "dgvSueteres";
			this.dgvSueteres.ReadOnly = true;
			this.dgvSueteres.RowHeadersWidth = 51;
			this.dgvSueteres.RowTemplate.Height = 24;
			this.dgvSueteres.Size = new System.Drawing.Size(979, 291);
			this.dgvSueteres.TabIndex = 0;
			// 
			// empleadosBindingSource
			// 
			this.empleadosBindingSource.DataSource = typeof(Models.Empleados);
			// 
			// sueterBindingSource
			// 
			this.sueterBindingSource.DataSource = typeof(Models.Sueter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Listar Suéteres";
			// 
			// idSueterDataGridViewTextBoxColumn
			// 
			this.idSueterDataGridViewTextBoxColumn.DataPropertyName = "Id_Sueter";
			this.idSueterDataGridViewTextBoxColumn.HeaderText = "Id Sueter";
			this.idSueterDataGridViewTextBoxColumn.MaxInputLength = 60;
			this.idSueterDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idSueterDataGridViewTextBoxColumn.Name = "idSueterDataGridViewTextBoxColumn";
			this.idSueterDataGridViewTextBoxColumn.ReadOnly = true;
			this.idSueterDataGridViewTextBoxColumn.Width = 60;
			// 
			// noSucursalDataGridViewTextBoxColumn
			// 
			this.noSucursalDataGridViewTextBoxColumn.DataPropertyName = "No_Sucursal";
			this.noSucursalDataGridViewTextBoxColumn.HeaderText = "No Sucursal";
			this.noSucursalDataGridViewTextBoxColumn.MaxInputLength = 65;
			this.noSucursalDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.noSucursalDataGridViewTextBoxColumn.Name = "noSucursalDataGridViewTextBoxColumn";
			this.noSucursalDataGridViewTextBoxColumn.ReadOnly = true;
			this.noSucursalDataGridViewTextBoxColumn.Width = 65;
			// 
			// noTallerDataGridViewTextBoxColumn
			// 
			this.noTallerDataGridViewTextBoxColumn.DataPropertyName = "No_Taller";
			this.noTallerDataGridViewTextBoxColumn.HeaderText = "No Taller";
			this.noTallerDataGridViewTextBoxColumn.MaxInputLength = 60;
			this.noTallerDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.noTallerDataGridViewTextBoxColumn.Name = "noTallerDataGridViewTextBoxColumn";
			this.noTallerDataGridViewTextBoxColumn.ReadOnly = true;
			this.noTallerDataGridViewTextBoxColumn.Width = 60;
			// 
			// tipoDataGridViewTextBoxColumn
			// 
			this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
			this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
			this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
			this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
			this.tipoDataGridViewTextBoxColumn.Width = 125;
			// 
			// tallaDataGridViewTextBoxColumn
			// 
			this.tallaDataGridViewTextBoxColumn.DataPropertyName = "Talla";
			this.tallaDataGridViewTextBoxColumn.HeaderText = "Talla";
			this.tallaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tallaDataGridViewTextBoxColumn.Name = "tallaDataGridViewTextBoxColumn";
			this.tallaDataGridViewTextBoxColumn.ReadOnly = true;
			this.tallaDataGridViewTextBoxColumn.Width = 125;
			// 
			// unidadesDataGridViewTextBoxColumn
			// 
			this.unidadesDataGridViewTextBoxColumn.DataPropertyName = "Unidades";
			this.unidadesDataGridViewTextBoxColumn.HeaderText = "Unidades";
			this.unidadesDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.unidadesDataGridViewTextBoxColumn.Name = "unidadesDataGridViewTextBoxColumn";
			this.unidadesDataGridViewTextBoxColumn.ReadOnly = true;
			this.unidadesDataGridViewTextBoxColumn.Width = 125;
			// 
			// precioDataGridViewTextBoxColumn
			// 
			this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
			this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
			this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
			this.precioDataGridViewTextBoxColumn.ReadOnly = true;
			this.precioDataGridViewTextBoxColumn.Width = 125;
			// 
			// FrmListarSueteres
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1014, 422);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvSueteres);
			this.Name = "FrmListarSueteres";
			this.Text = "FrmListarSueteres";
			((System.ComponentModel.ISupportInitialize)(this.dgvSueteres)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sueterBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSueteres;
		private System.Windows.Forms.BindingSource sueterBindingSource;
		private System.Windows.Forms.BindingSource empleadosBindingSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idSueterDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noSucursalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn noTallerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tallaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unidadesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
	}
}