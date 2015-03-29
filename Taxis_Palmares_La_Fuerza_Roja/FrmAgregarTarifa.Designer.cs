namespace Taxis_Palmares_La_Fuerza_Roja
{
    partial class FrmAgregarTarifa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarTarifa));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbAgregarTarifa = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.txtId_Tarifas = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtExtras = new System.Windows.Forms.TextBox();
            this.lblExtras = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblId_Tarifa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbAgregarTarifa.SuspendLayout();
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
            // gbAgregarTarifa
            // 
            this.gbAgregarTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarTarifa.Controls.Add(this.label1);
            this.gbAgregarTarifa.Controls.Add(this.txtMonto);
            this.gbAgregarTarifa.Controls.Add(this.label5);
            this.gbAgregarTarifa.Controls.Add(this.txtId_Tarifas);
            this.gbAgregarTarifa.Controls.Add(this.btnCancelar);
            this.gbAgregarTarifa.Controls.Add(this.pictureBox1);
            this.gbAgregarTarifa.Controls.Add(this.btnGuardar);
            this.gbAgregarTarifa.Controls.Add(this.txtExtras);
            this.gbAgregarTarifa.Controls.Add(this.lblExtras);
            this.gbAgregarTarifa.Controls.Add(this.txtDistancia);
            this.gbAgregarTarifa.Controls.Add(this.txtLugar);
            this.gbAgregarTarifa.Controls.Add(this.lblDistancia);
            this.gbAgregarTarifa.Controls.Add(this.lblLugar);
            this.gbAgregarTarifa.Controls.Add(this.lblMonto);
            this.gbAgregarTarifa.Controls.Add(this.lblId_Tarifa);
            this.gbAgregarTarifa.Location = new System.Drawing.Point(12, 12);
            this.gbAgregarTarifa.Name = "gbAgregarTarifa";
            this.gbAgregarTarifa.Size = new System.Drawing.Size(464, 385);
            this.gbAgregarTarifa.TabIndex = 6;
            this.gbAgregarTarifa.TabStop = false;
            this.gbAgregarTarifa.Text = "Agregar Tarifa";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(110, 71);
            this.txtMonto.Mask = "999999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(180, 20);
            this.txtMonto.TabIndex = 2;
            // 
            // txtId_Tarifas
            // 
            this.txtId_Tarifas.Location = new System.Drawing.Point(110, 39);
            this.txtId_Tarifas.Mask = "999999999";
            this.txtId_Tarifas.Name = "txtId_Tarifas";
            this.txtId_Tarifas.Size = new System.Drawing.Size(180, 20);
            this.txtId_Tarifas.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 85);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txtExtras
            // 
            this.txtExtras.Location = new System.Drawing.Point(110, 178);
            this.txtExtras.MaxLength = 50;
            this.txtExtras.Multiline = true;
            this.txtExtras.Name = "txtExtras";
            this.txtExtras.Size = new System.Drawing.Size(338, 99);
            this.txtExtras.TabIndex = 5;
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Location = new System.Drawing.Point(24, 181);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(42, 13);
            this.lblExtras.TabIndex = 30;
            this.lblExtras.Text = "Extras :";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(110, 143);
            this.txtDistancia.MaxLength = 20;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(180, 20);
            this.txtDistancia.TabIndex = 4;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(110, 109);
            this.txtLugar.MaxLength = 50;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(180, 20);
            this.txtLugar.TabIndex = 3;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(24, 146);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(57, 13);
            this.lblDistancia.TabIndex = 25;
            this.lblDistancia.Text = "Distancia :";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(24, 112);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(40, 13);
            this.lblLugar.TabIndex = 24;
            this.lblLugar.Text = "Lugar :";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(24, 78);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 13);
            this.lblMonto.TabIndex = 23;
            this.lblMonto.Text = "Monto :";
            // 
            // lblId_Tarifa
            // 
            this.lblId_Tarifa.AutoSize = true;
            this.lblId_Tarifa.Location = new System.Drawing.Point(24, 42);
            this.lblId_Tarifa.Name = "lblId_Tarifa";
            this.lblId_Tarifa.Size = new System.Drawing.Size(52, 13);
            this.lblId_Tarifa.TabIndex = 22;
            this.lblId_Tarifa.Text = "Id Tarifa :";
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
            this.label1.TabIndex = 38;
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
            this.label5.TabIndex = 37;
            this.label5.Text = "Cancelar";
            // 
            // FrmAgregarTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(488, 409);
            this.Controls.Add(this.gbAgregarTarifa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAgregarTarifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Tarifa";
            this.Load += new System.EventHandler(this.FrmAgregarTarifa_Load);
            this.gbAgregarTarifa.ResumeLayout(false);
            this.gbAgregarTarifa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbAgregarTarifa;
        private System.Windows.Forms.TextBox txtExtras;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblId_Tarifa;
        private System.Windows.Forms.MaskedTextBox txtId_Tarifas;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}