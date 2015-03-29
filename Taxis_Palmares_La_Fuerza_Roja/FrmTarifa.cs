using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Taxis_Palmares;

namespace Taxis_Palmares_La_Fuerza_Roja
{
    public partial class FrmTarifa : Form
    {
        //para las dependencias de usuarios
        public Taxis_Palmares.Usuario UserOn { get; set; }

        public FrmTarifa()
        {
            InitializeComponent();
        }

        private void MostrarTarifas()
        {
            Gestor objGestor = new Gestor();
            gvTarifas.DataSource = objGestor.ConsultaMasivaTarifa();
            objGestor = null;
        }

        private void FrmTarifa_Load(object sender, EventArgs e)
        {
            MostrarTarifas();
        }
        
        private void FrmTarifa_Load_1(object sender, EventArgs e)
        {
            btnActualizar.Visible = UserOn.EsAdmin;
            lblACTUALIZAR.Visible = UserOn.EsAdmin;
        }
                
        private void btnCargar_Click(object sender, EventArgs e)
        {
            MostrarTarifas();
        }

        private void gvTarifas_MouseClick(object sender, MouseEventArgs e)
        {
            if (gvTarifas.CurrentRow != null)
            {
                DataGridViewRow rowActual = gvTarifas.CurrentRow;
                string IdSeleccionado = rowActual.Cells[0].Value.ToString();
                lblSeleccionado.Text = IdSeleccionado;
            }
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarTarifa objAgregar = new FrmAgregarTarifa();
            objAgregar.ShowDialog();
            if (objAgregar.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //Debe mostrar el grid con todos las tarifas para que incluya
                //el recién agregado
                MostrarTarifas();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (gvTarifas.CurrentRow != null)
            {
                int Id_Tarifas = Convert.ToInt32(gvTarifas.CurrentRow.Cells[0].Value.ToString());
                decimal Monto = Convert.ToDecimal(gvTarifas.CurrentRow.Cells[1].Value.ToString());
                string Lugar = gvTarifas.CurrentRow.Cells[2].Value.ToString();
                string Distancia = gvTarifas.CurrentRow.Cells[3].Value.ToString(); 
                string Extras = gvTarifas.CurrentRow.Cells[4].Value.ToString();

                Tarifa objTarifa = new Tarifa(Id_Tarifas, Monto, Lugar, Distancia, Extras);

                FrmActualizarTarifa objActualizar = new FrmActualizarTarifa();  
                objActualizar.TarifaSeleccionado = objTarifa;
                objActualizar.ShowDialog();

                if (objActualizar.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    MostrarTarifas();
                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}
