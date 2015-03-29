namespace Taxis_Palmares_La_Fuerza_Roja
{
    partial class FrmAgregarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarFactura));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbAgregarLlamada = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero_Factura = new System.Windows.Forms.MaskedTextBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.cboVehiculo = new System.Windows.Forms.ComboBox();
            this.cboTaxista = new System.Windows.Forms.ComboBox();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.lblTaxista = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblNumero_Factura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAgregarLlamada.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 85);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(329, 294);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 64);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(156, 294);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 64);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbAgregarLlamada
            // 
            this.gbAgregarLlamada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarLlamada.Controls.Add(this.label1);
            this.gbAgregarLlamada.Controls.Add(this.txtMonto);
            this.gbAgregarLlamada.Controls.Add(this.label5);
            this.gbAgregarLlamada.Controls.Add(this.btnCancelar);
            this.gbAgregarLlamada.Controls.Add(this.pictureBox1);
            this.gbAgregarLlamada.Controls.Add(this.btnGuardar);
            this.gbAgregarLlamada.Controls.Add(this.txtNumero_Factura);
            this.gbAgregarLlamada.Controls.Add(this.txtFecha);
            this.gbAgregarLlamada.Controls.Add(this.cboVehiculo);
            this.gbAgregarLlamada.Controls.Add(this.cboTaxista);
            this.gbAgregarLlamada.Controls.Add(this.txtDetalles);
            this.gbAgregarLlamada.Controls.Add(this.lblTaxista);
            this.gbAgregarLlamada.Controls.Add(this.lblVehiculo);
            this.gbAgregarLlamada.Controls.Add(this.lblDetalles);
            this.gbAgregarLlamada.Controls.Add(this.lblFecha);
            this.gbAgregarLlamada.Controls.Add(this.lblMonto);
            this.gbAgregarLlamada.Controls.Add(this.lblNumero_Factura);
            this.gbAgregarLlamada.Location = new System.Drawing.Point(12, 12);
            this.gbAgregarLlamada.Name = "gbAgregarLlamada";
            this.gbAgregarLlamada.Size = new System.Drawing.Size(464, 385);
            this.gbAgregarLlamada.TabIndex = 6;
            this.gbAgregarLlamada.TabStop = false;
            this.gbAgregarLlamada.Text = "Agregar Llamada";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(119, 68);
            this.txtMonto.Mask = "999999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(180, 20);
            this.txtMonto.TabIndex = 2;
            // 
            // txtNumero_Factura
            // 
            this.txtNumero_Factura.Location = new System.Drawing.Point(119, 29);
            this.txtNumero_Factura.Mask = "999999999";
            this.txtNumero_Factura.Name = "txtNumero_Factura";
            this.txtNumero_Factura.ReadOnly = true;
            this.txtNumero_Factura.Size = new System.Drawing.Size(180, 20);
            this.txtNumero_Factura.TabIndex = 1;
            // 
            // txtFecha
            // 
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(119, 105);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(180, 20);
            this.txtFecha.TabIndex = 3;
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.Location = new System.Drawing.Point(119, 142);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(180, 21);
            this.cboVehiculo.TabIndex = 4;
            // 
            // cboTaxista
            // 
            this.cboTaxista.FormattingEnabled = true;
            this.cboTaxista.Location = new System.Drawing.Point(119, 179);
            this.cboTaxista.Name = "cboTaxista";
            this.cboTaxista.Size = new System.Drawing.Size(180, 21);
            this.cboTaxista.TabIndex = 5;
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(119, 215);
            this.txtDetalles.MaxLength = 200;
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(324, 65);
            this.txtDetalles.TabIndex = 6;
            // 
            // lblTaxista
            // 
            this.lblTaxista.AutoSize = true;
            this.lblTaxista.Location = new System.Drawing.Point(24, 187);
            this.lblTaxista.Name = "lblTaxista";
            this.lblTaxista.Size = new System.Drawing.Size(47, 13);
            this.lblTaxista.TabIndex = 12;
            this.lblTaxista.Text = "Taxista :";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(24, 150);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(54, 13);
            this.lblVehiculo.TabIndex = 10;
            this.lblVehiculo.Text = "Vehiculo :";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(24, 235);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(51, 13);
            this.lblDetalles.TabIndex = 3;
            this.lblDetalles.Text = "Detalles :";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(24, 112);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha :";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(24, 75);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 13);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto :";
            // 
            // lblNumero_Factura
            // 
            this.lblNumero_Factura.AutoSize = true;
            this.lblNumero_Factura.Location = new System.Drawing.Point(24, 36);
            this.lblNumero_Factura.Name = "lblNumero_Factura";
            this.lblNumero_Factura.Size = new System.Drawing.Size(89, 13);
            this.lblNumero_Factura.TabIndex = 0;
            this.lblNumero_Factura.Text = "Numero Factura :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(152, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Guardar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(326, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Cancelar";
            // 
            // FrmAgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(488, 409);
            this.Controls.Add(this.gbAgregarLlamada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAgregarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAgregarFactura";
            this.Load += new System.EventHandler(this.FrmAgregarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAgregarLlamada.ResumeLayout(false);
            this.gbAgregarLlamada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbAgregarLlamada;
        private System.Windows.Forms.ComboBox cboVehiculo;
        private System.Windows.Forms.ComboBox cboTaxista;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label lblTaxista;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblNumero_Factura;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.MaskedTextBox txtNumero_Factura;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;

    }
}