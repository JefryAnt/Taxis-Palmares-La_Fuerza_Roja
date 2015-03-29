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
    public partial class FrmActualizarTarifa : Form
    {

        #region Propiedades

        public Tarifa TarifaSeleccionado { get; set; }

        #endregion Propiedades


        public FrmActualizarTarifa()
        {
            InitializeComponent();
        }

        private void FrmActualizarTarifa_Load(object sender, EventArgs e)
        {

            txtId_Tarifas.Text = TarifaSeleccionado.Id_Tarifas.ToString();
            txtMonto.Text = TarifaSeleccionado.Monto.ToString();
            txtLugar.Text = TarifaSeleccionado.Lugar;
            txtDistancia.Text = TarifaSeleccionado.Distancia;
            txtExtras.Text = TarifaSeleccionado.Extras;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            Gestor objGestor = new Gestor();
            int registrosAfectados = objGestor.ActualizarTarifa(Convert.ToInt32(txtId_Tarifas.Text), Convert.ToDecimal(txtMonto.Text), txtLugar.Text, txtDistancia.Text, txtExtras.Text);

            if (registrosAfectados >= 0)
            {
                MessageBox.Show("La Tarifa ha sido Actualizada con exito", "Tarifa Actualizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo Actualizar la Tarifa por error de datos", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            objGestor = null;
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
