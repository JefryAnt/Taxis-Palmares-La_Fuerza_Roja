namespace Taxis_Palmares_La_Fuerza_Roja
{
    partial class FrmActualizarTarifa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarTarifa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbActualizarTarifa = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.txtExtras = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtId_Tarifas = new System.Windows.Forms.MaskedTextBox();
            this.lblExtras = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblId_Tarifa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbActualizarTarifa.SuspendLayout();
            this.SuspendLayout();
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
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
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
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(156, 294);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(64, 64);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gbActualizarTarifa
            // 
            this.gbActualizarTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActualizarTarifa.Controls.Add(this.label1);
            this.gbActualizarTarifa.Controls.Add(this.txtMonto);
            this.gbActualizarTarifa.Controls.Add(this.label5);
            this.gbActualizarTarifa.Controls.Add(this.txtExtras);
            this.gbActualizarTarifa.Controls.Add(this.txtDistancia);
            this.gbActualizarTarifa.Controls.Add(this.txtLugar);
            this.gbActualizarTarifa.Controls.Add(this.txtId_Tarifas);
            this.gbActualizarTarifa.Controls.Add(this.lblExtras);
            this.gbActualizarTarifa.Controls.Add(this.lblDistancia);
            this.gbActualizarTarifa.Controls.Add(this.lblLugar);
            this.gbActualizarTarifa.Controls.Add(this.lblMonto);
            this.gbActualizarTarifa.Controls.Add(this.lblId_Tarifa);
            this.gbActualizarTarifa.Controls.Add(this.btnCancelar);
            this.gbActualizarTarifa.Controls.Add(this.pictureBox1);
            this.gbActualizarTarifa.Controls.Add(this.btnActualizar);
            this.gbActualizarTarifa.Location = new System.Drawing.Point(12, 12);
            this.gbActualizarTarifa.Name = "gbActualizarTarifa";
            this.gbActualizarTarifa.Size = new System.Drawing.Size(464, 385);
            this.gbActualizarTarifa.TabIndex = 6;
            this.gbActualizarTarifa.TabStop = false;
            this.gbActualizarTarifa.Text = "Actualizar Tarifa";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(110, 71);
            this.txtMonto.Mask = "999999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(180, 20);
            this.txtMonto.TabIndex = 2;
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
            // txtId_Tarifas
            // 
            this.txtId_Tarifas.Location = new System.Drawing.Point(110, 39);
            this.txtId_Tarifas.Mask = "999999999";
            this.txtId_Tarifas.Name = "txtId_Tarifas";
            this.txtId_Tarifas.ReadOnly = true;
            this.txtId_Tarifas.Size = new System.Drawing.Size(180, 20);
            this.txtId_Tarifas.TabIndex = 1;
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Location = new System.Drawing.Point(24, 181);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(42, 13);
            this.lblExtras.TabIndex = 40;
            this.lblExtras.Text = "Extras :";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(24, 146);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(57, 13);
            this.lblDistancia.TabIndex = 37;
            this.lblDistancia.Text = "Distancia :";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(24, 112);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(40, 13);
            this.lblLugar.TabIndex = 36;
            this.lblLugar.Text = "Lugar :";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(24, 78);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 13);
            this.lblMonto.TabIndex = 35;
            this.lblMonto.Text = "Monto :";
            // 
            // lblId_Tarifa
            // 
            this.lblId_Tarifa.AutoSize = true;
            this.lblId_Tarifa.Location = new System.Drawing.Point(24, 42);
            this.lblId_Tarifa.Name = "lblId_Tarifa";
            this.lblId_Tarifa.Size = new System.Drawing.Size(52, 13);
            this.lblId_Tarifa.TabIndex = 34;
            this.lblId_Tarifa.Text = "Id Tarifa :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(148, 356);
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
            this.label5.Location = new System.Drawing.Point(326, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Cancelar";
            // 
            // FrmActualizarTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(488, 409);
            this.Controls.Add(this.gbActualizarTarifa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmActualizarTarifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar Tarifa";
            this.Load += new System.EventHandler(this.FrmActualizarTarifa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbActualizarTarifa.ResumeLayout(false);
            this.gbActualizarTarifa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox gbActualizarTarifa;
        private System.Windows.Forms.MaskedTextBox txtId_Tarifas;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblId_Tarifa;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.TextBox txtExtras;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}