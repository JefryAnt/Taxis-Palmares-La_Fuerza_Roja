namespace Taxis_Palmares_La_Fuerza_Roja
{
    partial class FrmActualizarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarCliente));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbActualizarCliente = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbActualizarCliente.SuspendLayout();
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
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(156, 294);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(64, 64);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gbActualizarCliente
            // 
            this.gbActualizarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActualizarCliente.Controls.Add(this.label1);
            this.gbActualizarCliente.Controls.Add(this.txtTelefono);
            this.gbActualizarCliente.Controls.Add(this.label5);
            this.gbActualizarCliente.Controls.Add(this.txtCedula);
            this.gbActualizarCliente.Controls.Add(this.btnCancelar);
            this.gbActualizarCliente.Controls.Add(this.pictureBox1);
            this.gbActualizarCliente.Controls.Add(this.btnActualizar);
            this.gbActualizarCliente.Controls.Add(this.txtDireccion);
            this.gbActualizarCliente.Controls.Add(this.lblDireccion);
            this.gbActualizarCliente.Controls.Add(this.txtApellido);
            this.gbActualizarCliente.Controls.Add(this.txtNombre);
            this.gbActualizarCliente.Controls.Add(this.lblTelefono);
            this.gbActualizarCliente.Controls.Add(this.lblApellido);
            this.gbActualizarCliente.Controls.Add(this.lblNombre);
            this.gbActualizarCliente.Controls.Add(this.lblCedula);
            this.gbActualizarCliente.Location = new System.Drawing.Point(12, 12);
            this.gbActualizarCliente.Name = "gbActualizarCliente";
            this.gbActualizarCliente.Size = new System.Drawing.Size(464, 385);
            this.gbActualizarCliente.TabIndex = 6;
            this.gbActualizarCliente.TabStop = false;
            this.gbActualizarCliente.Text = "Actualizar Cliente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(110, 139);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(110, 39);
            this.txtCedula.Mask = "999999999";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(180, 20);
            this.txtCedula.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 85);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.lblDireccion.TabIndex = 20;
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
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Telefono :";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(24, 112);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellido :";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblCedula
            // 
            this.lblCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(24, 42);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(46, 13);
            this.lblCedula.TabIndex = 12;
            this.lblCedula.Text = "Cedula :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(148, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Actualizar";
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
            this.label5.TabIndex = 50;
            this.label5.Text = "Cancelar";
            // 
            // FrmActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(488, 409);
            this.Controls.Add(this.gbActualizarCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmActualizarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar Cliente";
            this.Load += new System.EventHandler(this.FrmActualizarCliente_Load);
            this.gbActualizarCliente.ResumeLayout(false);
            this.gbActualizarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox gbActualizarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}