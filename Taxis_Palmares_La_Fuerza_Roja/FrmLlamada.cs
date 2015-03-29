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
    public partial class FrmLlamada : Form
    {
        public FrmLlamada()
        {
            InitializeComponent();
        }

        private void MostrarLlamadas()
        {
            Gestor objGestor = new Gestor();
            gvLlamadas.DataSource = objGestor.ConsultaMasivaLlamada();
            objGestor = null;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            MostrarLlamadas();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            MostrarLlamadas();
        }

        private void gvLlamadas_MouseClick(object sender, MouseEventArgs e)
        {
            if (gvLlamadas.CurrentRow != null)
            {
                DataGridViewRow rowActual = gvLlamadas.CurrentRow;
                string IdSeleccionado = rowActual.Cells[0].Value.ToString();
                lblSeleccionado.Text = IdSeleccionado;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarLlamada objAgregar = new FrmAgregarLlamada();
            objAgregar.ShowDialog();
            if (objAgregar.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //Debe mostrar el grid con todos las llamadas para que incluya
                //el recién agregado
                MostrarLlamadas();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteLlamada objAplicacion = new FrmReporteLlamada();

            objAplicacion.ShowDialog();
        }
    }
}
