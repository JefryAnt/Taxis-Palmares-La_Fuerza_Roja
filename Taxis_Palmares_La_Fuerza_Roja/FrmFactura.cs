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
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void MostrarFacturas()
        {
            Gestor objGestor = new Gestor();
            gvFacturas.DataSource = objGestor.ConsultaMasivaFactura();
            objGestor = null;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            MostrarFacturas();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            MostrarFacturas();
        }

        private void gvFacturas_MouseClick(object sender, MouseEventArgs e)
        {
            if (gvFacturas.CurrentRow != null)
            {
                DataGridViewRow rowActual = gvFacturas.CurrentRow;
                string IdSeleccionado = rowActual.Cells[0].Value.ToString();
                lblSeleccionado.Text = IdSeleccionado;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarFactura objAgregar = new FrmAgregarFactura();
            objAgregar.ShowDialog();
            if (objAgregar.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //Debe mostrar el grid con todos las facturas para que incluya
                //el recién agregado
                MostrarFacturas();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteFactura objAplicacion = new FrmReporteFactura();

            objAplicacion.ShowDialog();
        }
    }
}
