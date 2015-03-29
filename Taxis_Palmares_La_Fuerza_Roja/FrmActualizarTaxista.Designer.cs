namespace Taxis_Palmares_La_Fuerza_Roja
{
    partial class FrmActualizarTaxista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarTaxista));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbActualizarTaxista = new System.Windows.Forms.GroupBox();
            this.txtFecha_Nacimineto = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo_Taxista = new System.Windows.Forms.TextBox();
            this.lblCodigo_Taxista = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtResidencia = new System.Windows.Forms.TextBox();
            this.lblResidencia = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha_Nacimineto = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbActualizarTaxista.SuspendLayout();
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
            this.btnCancelar.TabIndex = 8;
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
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gbActualizarTaxista
            // 
            this.gbActualizarTaxista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActualizarTaxista.Controls.Add(this.label1);
            this.gbActualizarTaxista.Controls.Add(this.label5);
            this.gbActualizarTaxista.Controls.Add(this.txtFecha_Nacimineto);
            this.gbActualizarTaxista.Controls.Add(this.txtTelefono);
            this.gbActualizarTaxista.Controls.Add(this.btnCancelar);
            this.gbActualizarTaxista.Controls.Add(this.txtIdentificacion);
            this.gbActualizarTaxista.Controls.Add(this.btnActualizar);
            this.gbActualizarTaxista.Controls.Add(this.txtCodigo_Taxista);
            this.gbActualizarTaxista.Controls.Add(this.lblCodigo_Taxista);
            this.gbActualizarTaxista.Controls.Add(this.lblTelefono);
            this.gbActualizarTaxista.Controls.Add(this.txtResidencia);
            this.gbActualizarTaxista.Controls.Add(this.lblResidencia);
            this.gbActualizarTaxista.Controls.Add(this.txtApellido);
            this.gbActualizarTaxista.Controls.Add(this.txtNombre);
            this.gbActualizarTaxista.Controls.Add(this.lblApellido);
            this.gbActualizarTaxista.Controls.Add(this.lblNombre);
            this.gbActualizarTaxista.Controls.Add(this.lblFecha_Nacimineto);
            this.gbActualizarTaxista.Controls.Add(this.lblIdentificacion);
            this.gbActualizarTaxista.Controls.Add(this.pictureBox1);
            this.gbActualizarTaxista.Location = new System.Drawing.Point(12, 12);
            this.gbActualizarTaxista.Name = "gbActualizarTaxista";
            this.gbActualizarTaxista.Size = new System.Drawing.Size(464, 385);
            this.gbActualizarTaxista.TabIndex = 6;
            this.gbActualizarTaxista.TabStop = false;
            this.gbActualizarTaxista.Text = "Actualizar Taxista";
            // 
            // txtFecha_Nacimineto
            // 
            this.txtFecha_Nacimineto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha_Nacimineto.Location = new System.Drawing.Point(123, 58);
            this.txtFecha_Nacimineto.Name = "txtFecha_Nacimineto";
            this.txtFecha_Nacimineto.Size = new System.Drawing.Size(180, 20);
            this.txtFecha_Nacimineto.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(123, 162);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(123, 20);
            this.txtIdentificacion.Mask = "999999999";
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(180, 20);
            this.txtIdentificacion.TabIndex = 1;
            // 
            // txtCodigo_Taxista
            // 
            this.txtCodigo_Taxista.Location = new System.Drawing.Point(123, 199);
            this.txtCodigo_Taxista.MaxLength = 20;
            this.txtCodigo_Taxista.Name = "txtCodigo_Taxista";
            this.txtCodigo_Taxista.Size = new System.Drawing.Size(180, 20);
            this.txtCodigo_Taxista.TabIndex = 6;
            // 
            // lblCodigo_Taxista
            // 
            this.lblCodigo_Taxista.AutoSize = true;
            this.lblCodigo_Taxista.Location = new System.Drawing.Point(24, 206);
            this.lblCodigo_Taxista.Name = "lblCodigo_Taxista";
            this.lblCodigo_Taxista.Size = new System.Drawing.Size(83, 13);
            this.lblCodigo_Taxista.TabIndex = 46;
            this.lblCodigo_Taxista.Text = "Codigo Taxista :";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(24, 165);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 13);
            this.lblTelefono.TabIndex = 44;
            this.lblTelefono.Text = "Telefono :";
            // 
            // txtResidencia
            // 
            this.txtResidencia.Location = new System.Drawing.Point(123, 233);
            this.txtResidencia.MaxLength = 250;
            this.txtResidencia.Multiline = true;
            this.txtResidencia.Name = "txtResidencia";
            this.txtResidencia.Size = new System.Drawing.Size(323, 53);
            this.txtResidencia.TabIndex = 7;
            // 
            // lblResidencia
            // 
            this.lblResidencia.AutoSize = true;
            this.lblResidencia.Location = new System.Drawing.Point(24, 246);
            this.lblResidencia.Name = "lblResidencia";
            this.lblResidencia.Size = new System.Drawing.Size(66, 13);
            this.lblResidencia.TabIndex = 42;
            this.lblResidencia.Text = "Residencia :";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(123, 128);
            this.txtApellido.MaxLength = 25;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 20);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 93);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(24, 135);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 38;
            this.lblApellido.Text = "Apellido :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblFecha_Nacimineto
            // 
            this.lblFecha_Nacimineto.AutoSize = true;
            this.lblFecha_Nacimineto.Location = new System.Drawing.Point(24, 64);
            this.lblFecha_Nacimineto.Name = "lblFecha_Nacimineto";
            this.lblFecha_Nacimineto.Size = new System.Drawing.Size(99, 13);
            this.lblFecha_Nacimineto.TabIndex = 36;
            this.lblFecha_Nacimineto.Text = "Fecha Nacimineto :";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(24, 27);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(76, 13);
            this.lblIdentificacion.TabIndex = 35;
            this.lblIdentificacion.Text = "Identificacion :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 85);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(148, 357);
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
            this.label5.Location = new System.Drawing.Point(326, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Cancelar";
            // 
            // FrmActualizarTaxista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(488, 409);
            this.Controls.Add(this.gbActualizarTaxista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmActualizarTaxista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar Taxista";
            this.Load += new System.EventHandler(this.FrmActualizarTaxista_Load);
            this.gbActualizarTaxista.ResumeLayout(false);
            this.gbActualizarTaxista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox gbActualizarTaxista;
        private System.Windows.Forms.MaskedTextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtCodigo_Taxista;
        private System.Windows.Forms.Label lblCodigo_Taxista;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtResidencia;
        private System.Windows.Forms.Label lblResidencia;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha_Nacimineto;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker txtFecha_Nacimineto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}