namespace Taxis_Palmares_La_Fuerza_Roja
{
    partial class FrmAgregarLlamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarLlamada));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbAgregarLlamada = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cboVehiculo = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
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
            this.pictureBox1.TabIndex = 18;
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
            this.gbAgregarLlamada.Controls.Add(this.label5);
            this.gbAgregarLlamada.Controls.Add(this.lblCodigo);
            this.gbAgregarLlamada.Controls.Add(this.txtCodigo);
            this.gbAgregarLlamada.Controls.Add(this.btnCancelar);
            this.gbAgregarLlamada.Controls.Add(this.pictureBox1);
            this.gbAgregarLlamada.Controls.Add(this.btnGuardar);
            this.gbAgregarLlamada.Controls.Add(this.cboVehiculo);
            this.gbAgregarLlamada.Controls.Add(this.cboCliente);
            this.gbAgregarLlamada.Controls.Add(this.txtNombreCliente);
            this.gbAgregarLlamada.Controls.Add(this.txtDireccion);
            this.gbAgregarLlamada.Controls.Add(this.lblCliente);
            this.gbAgregarLlamada.Controls.Add(this.txtHora);
            this.gbAgregarLlamada.Controls.Add(this.lblVehiculo);
            this.gbAgregarLlamada.Controls.Add(this.lblNombreCliente);
            this.gbAgregarLlamada.Controls.Add(this.lblDireccion);
            this.gbAgregarLlamada.Controls.Add(this.lblHora);
            this.gbAgregarLlamada.Location = new System.Drawing.Point(12, 12);
            this.gbAgregarLlamada.Name = "gbAgregarLlamada";
            this.gbAgregarLlamada.Size = new System.Drawing.Size(464, 385);
            this.gbAgregarLlamada.TabIndex = 6;
            this.gbAgregarLlamada.TabStop = false;
            this.gbAgregarLlamada.Text = "Agregar Llamada";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 21;
            this.lblCodigo.Text = "Codigo :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(119, 29);
            this.txtCodigo.MaxLength = 9;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(180, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.Location = new System.Drawing.Point(119, 105);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(180, 21);
            this.cboVehiculo.TabIndex = 3;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(119, 142);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(180, 21);
            this.cboCliente.TabIndex = 4;
            this.cboCliente.SelectionChangeCommitted += new System.EventHandler(this.cboCliente_SelectionChangeCommitted);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(119, 179);
            this.txtNombreCliente.MaxLength = 50;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(180, 20);
            this.txtNombreCliente.TabIndex = 5;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(119, 215);
            this.txtDireccion.MaxLength = 250;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(324, 65);
            this.txtDireccion.TabIndex = 6;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(24, 150);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente :";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(119, 68);
            this.txtHora.MaxLength = 9;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(180, 20);
            this.txtHora.TabIndex = 2;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(24, 112);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(54, 13);
            this.lblVehiculo.TabIndex = 10;
            this.lblVehiculo.Text = "Vehiculo :";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(24, 187);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(85, 13);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre Cliente :";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(24, 235);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(58, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion :";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(24, 75);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 13);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora :";
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
            this.label1.TabIndex = 40;
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
            this.label5.TabIndex = 39;
            this.label5.Text = "Cancelar";
            // 
            // FrmAgregarLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(488, 409);
            this.Controls.Add(this.gbAgregarLlamada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAgregarLlamada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Llamada";
            this.Load += new System.EventHandler(this.FrmAgregarLlamada_Load);
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
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cboVehiculo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;

    }
}