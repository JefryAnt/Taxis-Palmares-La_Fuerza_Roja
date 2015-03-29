namespace Taxis_Palmares_La_Fuerza_Roja
{
    partial class FrmTarifa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTarifa));
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gvTarifas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblACTUALIZAR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(28, 256);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.lblSeleccionado.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 95);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Transparent;
            this.btnCargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargar.BackgroundImage")));
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(544, 295);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(64, 64);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(294, 295);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(64, 64);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(180, 295);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(64, 64);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gvTarifas
            // 
            this.gvTarifas.AllowUserToAddRows = false;
            this.gvTarifas.AllowUserToDeleteRows = false;
            this.gvTarifas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTarifas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvTarifas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTarifas.Location = new System.Drawing.Point(31, 34);
            this.gvTarifas.Name = "gvTarifas";
            this.gvTarifas.ReadOnly = true;
            this.gvTarifas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvTarifas.Size = new System.Drawing.Size(658, 210);
            this.gvTarifas.TabIndex = 6;
            this.gvTarifas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvTarifas_MouseClick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(643, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 64);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(172, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "GUARDAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(655, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "SALIR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(541, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "CARGAR";
            // 
            // lblACTUALIZAR
            // 
            this.lblACTUALIZAR.AutoSize = true;
            this.lblACTUALIZAR.BackColor = System.Drawing.Color.Transparent;
            this.lblACTUALIZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACTUALIZAR.ForeColor = System.Drawing.Color.Black;
            this.lblACTUALIZAR.Location = new System.Drawing.Point(272, 358);
            this.lblACTUALIZAR.Name = "lblACTUALIZAR";
            this.lblACTUALIZAR.Size = new System.Drawing.Size(103, 17);
            this.lblACTUALIZAR.TabIndex = 36;
            this.lblACTUALIZAR.Text = "ACTUALIZAR";
            // 
            // FrmTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 413);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblACTUALIZAR);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gvTarifas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTarifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TARIFAS";
            this.Load += new System.EventHandler(this.FrmTarifa_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarifas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView gvTarifas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblACTUALIZAR;
    }
}