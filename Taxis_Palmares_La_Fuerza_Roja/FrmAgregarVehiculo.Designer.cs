namespace Taxis_Palmares_La_Fuerza_Roja
{
    partial class FrmAgregarVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarVehiculo));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbAgregarVehiculo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.txtCapacidad = new System.Windows.Forms.MaskedTextBox();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboTaxista = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTaxista = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.gbAgregarVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancelar.TabIndex = 9;
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
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbAgregarVehiculo
            // 
            this.gbAgregarVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarVehiculo.Controls.Add(this.label1);
            this.gbAgregarVehiculo.Controls.Add(this.label5);
            this.gbAgregarVehiculo.Controls.Add(this.txtEstado);
            this.gbAgregarVehiculo.Controls.Add(this.txtCapacidad);
            this.gbAgregarVehiculo.Controls.Add(this.txtAno);
            this.gbAgregarVehiculo.Controls.Add(this.txtPlaca);
            this.gbAgregarVehiculo.Controls.Add(this.btnCancelar);
            this.gbAgregarVehiculo.Controls.Add(this.pictureBox1);
            this.gbAgregarVehiculo.Controls.Add(this.btnGuardar);
            this.gbAgregarVehiculo.Controls.Add(this.cboTaxista);
            this.gbAgregarVehiculo.Controls.Add(this.txtTipo);
            this.gbAgregarVehiculo.Controls.Add(this.lblTipo);
            this.gbAgregarVehiculo.Controls.Add(this.lblTaxista);
            this.gbAgregarVehiculo.Controls.Add(this.txtMarca);
            this.gbAgregarVehiculo.Controls.Add(this.lblMarca);
            this.gbAgregarVehiculo.Controls.Add(this.txtModelo);
            this.gbAgregarVehiculo.Controls.Add(this.lblModelo);
            this.gbAgregarVehiculo.Controls.Add(this.lblEstado);
            this.gbAgregarVehiculo.Controls.Add(this.lblAno);
            this.gbAgregarVehiculo.Controls.Add(this.lblCapacidad);
            this.gbAgregarVehiculo.Controls.Add(this.lblPlaca);
            this.gbAgregarVehiculo.Location = new System.Drawing.Point(12, 12);
            this.gbAgregarVehiculo.Name = "gbAgregarVehiculo";
            this.gbAgregarVehiculo.Size = new System.Drawing.Size(464, 385);
            this.gbAgregarVehiculo.TabIndex = 6;
            this.gbAgregarVehiculo.TabStop = false;
            this.gbAgregarVehiculo.Text = "Agregar Vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(152, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 36;
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
            this.label5.TabIndex = 35;
            this.label5.Text = "Cancelar";
            // 
            // txtEstado
            // 
            this.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.txtEstado.Location = new System.Drawing.Point(123, 118);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(180, 21);
            this.txtEstado.TabIndex = 4;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(123, 50);
            this.txtCapacidad.Mask = "999";
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(180, 20);
            this.txtCapacidad.TabIndex = 2;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(123, 81);
            this.txtAno.Mask = "99999";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(180, 20);
            this.txtAno.TabIndex = 3;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(123, 17);
            this.txtPlaca.Mask = "999999999";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(180, 20);
            this.txtPlaca.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 85);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // cboTaxista
            // 
            this.cboTaxista.FormattingEnabled = true;
            this.cboTaxista.Location = new System.Drawing.Point(123, 249);
            this.cboTaxista.Name = "cboTaxista";
            this.cboTaxista.Size = new System.Drawing.Size(180, 21);
            this.cboTaxista.TabIndex = 8;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(123, 217);
            this.txtTipo.MaxLength = 20;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(180, 20);
            this.txtTipo.TabIndex = 7;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(24, 224);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 13);
            this.lblTipo.TabIndex = 16;
            this.lblTipo.Text = "Tipo :";
            // 
            // lblTaxista
            // 
            this.lblTaxista.AutoSize = true;
            this.lblTaxista.Location = new System.Drawing.Point(24, 257);
            this.lblTaxista.Name = "lblTaxista";
            this.lblTaxista.Size = new System.Drawing.Size(47, 13);
            this.lblTaxista.TabIndex = 14;
            this.lblTaxista.Text = "Taxista :";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(123, 185);
            this.txtMarca.MaxLength = 20;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(180, 20);
            this.txtMarca.TabIndex = 6;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(24, 192);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 13);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca :";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(123, 151);
            this.txtModelo.MaxLength = 20;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(180, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(24, 158);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 13);
            this.lblModelo.TabIndex = 10;
            this.lblModelo.Text = "Modelo :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(24, 126);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado :";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(24, 88);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(32, 13);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Año :";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(24, 57);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(64, 13);
            this.lblCapacidad.TabIndex = 1;
            this.lblCapacidad.Text = "Capacidad :";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(24, 24);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(40, 13);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa :";
            // 
            // FrmAgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(488, 409);
            this.Controls.Add(this.gbAgregarVehiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAgregarVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Vehiculo";
            this.Load += new System.EventHandler(this.FrmAgregarVehiculo_Load);
            this.gbAgregarVehiculo.ResumeLayout(false);
            this.gbAgregarVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbAgregarVehiculo;
        private System.Windows.Forms.Label lblTaxista;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTaxista;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.MaskedTextBox txtCapacidad;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}