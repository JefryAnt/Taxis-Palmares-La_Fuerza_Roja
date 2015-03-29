namespace Taxis_Palmares_La_Fuerza_Roja
{
    partial class FrmAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCliente));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbAgregarCliente = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.gbAgregarCliente.SuspendLayout();
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
            this.btnCancelar.TabIndex = 6;
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
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbAgregarCliente
            // 
            this.gbAgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarCliente.Controls.Add(this.label1);
            this.gbAgregarCliente.Controls.Add(this.txtTelefono);
            this.gbAgregarCliente.Controls.Add(this.label5);
            this.gbAgregarCliente.Controls.Add(this.btnCancelar);
            this.gbAgregarCliente.Controls.Add(this.pictureBox1);
            this.gbAgregarCliente.Controls.Add(this.btnGuardar);
            this.gbAgregarCliente.Controls.Add(this.txtCedula);
            this.gbAgregarCliente.Controls.Add(this.txtDireccion);
            this.gbAgregarCliente.Controls.Add(this.lblDireccion);
            this.gbAgregarCliente.Controls.Add(this.txtApellido);
            this.gbAgregarCliente.Controls.Add(this.txtNombre);
            this.gbAgregarCliente.Controls.Add(this.lblTelefono);
            this.gbAgregarCliente.Controls.Add(this.lblApellido);
            this.gbAgregarCliente.Controls.Add(this.lblNombre);
            this.gbAgregarCliente.Controls.Add(this.lblCedula);
            this.gbAgregarCliente.Location = new System.Drawing.Point(12, 12);
            this.gbAgregarCliente.Name = "gbAgregarCliente";
            this.gbAgregarCliente.Size = new System.Drawing.Size(464, 385);
            this.gbAgregarCliente.TabIndex = 6;
            this.gbAgregarCliente.TabStop = false;
            this.gbAgregarCliente.Text = "Agregar Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(153, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Guardar";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(110, 139);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(326, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Cancelar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 85);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(110, 39);
            this.txtCedula.Mask = "999999999";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(180, 20);
            this.txtCedula.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDireccion.Location = new System.Drawing.Point(110, 178);
            this.txtDireccion.MaxLength = 250;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(338, 99);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(24, 181);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(58, 13);
            this.lblDireccion.TabIndex = 30;
            this.lblDireccion.Text = "Direccion :";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtApellido.Location = new System.Drawing.Point(110, 109);
            this.txtApellido.MaxLength = 25;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombre.Location = new System.Drawing.Point(110, 75);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(24, 146);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 13);
            this.lblTelefono.TabIndex = 26;
            this.lblTelefono.Text = "Telefono :";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(24, 112);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 25;
            this.lblApellido.Text = "Apellido :";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblCedula
            // 
            this.lblCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(24, 42);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(46, 13);
            this.lblCedula.TabIndex = 23;
            this.lblCedula.Text = "Cedula :";
            // 
            // FrmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(488, 409);
            this.Controls.Add(this.gbAgregarCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Cliente";
            this.gbAgregarCliente.ResumeLayout(false);
            this.gbAgregarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbAgregarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}