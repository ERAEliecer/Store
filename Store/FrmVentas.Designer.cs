
namespace Store
{
	partial class FrmVentas
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
			this.lblEmpleado = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnVender = new System.Windows.Forms.Button();
			this.dgvVenta = new System.Windows.Forms.DataGridView();
			this.cboSueteres = new System.Windows.Forms.ComboBox();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sueter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTotal = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
			this.SuspendLayout();
			// 
			// lblEmpleado
			// 
			this.lblEmpleado.AutoSize = true;
			this.lblEmpleado.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmpleado.Location = new System.Drawing.Point(29, 26);
			this.lblEmpleado.Name = "lblEmpleado";
			this.lblEmpleado.Size = new System.Drawing.Size(135, 29);
			this.lblEmpleado.TabIndex = 0;
			this.lblEmpleado.Text = "Empleado:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(93, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Sueter";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(396, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Cantidad";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(490, 85);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(128, 30);
			this.txtCantidad.TabIndex = 3;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(504, 145);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(114, 39);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnVender
			// 
			this.btnVender.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVender.Location = new System.Drawing.Point(586, 510);
			this.btnVender.Name = "btnVender";
			this.btnVender.Size = new System.Drawing.Size(104, 34);
			this.btnVender.TabIndex = 5;
			this.btnVender.Text = "Vender";
			this.btnVender.UseVisualStyleBackColor = true;
			this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
			// 
			// dgvVenta
			// 
			this.dgvVenta.AllowUserToDeleteRows = false;
			this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sueter,
            this.Cantidad,
            this.Precio,
            this.Subtotal});
			this.dgvVenta.Location = new System.Drawing.Point(34, 206);
			this.dgvVenta.Name = "dgvVenta";
			this.dgvVenta.ReadOnly = true;
			this.dgvVenta.RowHeadersWidth = 51;
			this.dgvVenta.RowTemplate.Height = 24;
			this.dgvVenta.Size = new System.Drawing.Size(656, 256);
			this.dgvVenta.TabIndex = 6;
			this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellContentClick);
			// 
			// cboSueteres
			// 
			this.cboSueteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSueteres.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboSueteres.FormattingEnabled = true;
			this.cboSueteres.Location = new System.Drawing.Point(167, 83);
			this.cboSueteres.Name = "cboSueteres";
			this.cboSueteres.Size = new System.Drawing.Size(201, 32);
			this.cboSueteres.TabIndex = 7;
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.MaxInputLength = 40;
			this.Id.MinimumWidth = 6;
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Id.Width = 40;
			// 
			// Sueter
			// 
			this.Sueter.HeaderText = "Sueter";
			this.Sueter.MaxInputLength = 100;
			this.Sueter.MinimumWidth = 6;
			this.Sueter.Name = "Sueter";
			this.Sueter.ReadOnly = true;
			this.Sueter.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.MaxInputLength = 100;
			this.Cantidad.MinimumWidth = 6;
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Precio
			// 
			this.Precio.HeaderText = "Precio";
			this.Precio.MaxInputLength = 100;
			this.Precio.MinimumWidth = 6;
			this.Precio.Name = "Precio";
			this.Precio.ReadOnly = true;
			this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Subtotal
			// 
			this.Subtotal.HeaderText = "Subtotal";
			this.Subtotal.MaxInputLength = 100;
			this.Subtotal.MinimumWidth = 6;
			this.Subtotal.Name = "Subtotal";
			this.Subtotal.ReadOnly = true;
			this.Subtotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(548, 474);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(57, 24);
			this.lblTotal.TabIndex = 8;
			this.lblTotal.Text = "Total";
			// 
			// FrmVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 556);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.cboSueteres);
			this.Controls.Add(this.dgvVenta);
			this.Controls.Add(this.btnVender);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblEmpleado);
			this.Name = "FrmVentas";
			this.Text = "Venta";
			this.Load += new System.EventHandler(this.FrmVentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblEmpleado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnVender;
		private System.Windows.Forms.DataGridView dgvVenta;
		private System.Windows.Forms.ComboBox cboSueteres;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sueter;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
		private System.Windows.Forms.Label lblTotal;
	}
}