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
    public partial class FrmActualizarVehiculo : Form
    {

        #region Propiedades

        public Vehiculo VehiculoSeleccionado { get; set; }

        #endregion Propiedades


        public FrmActualizarVehiculo()
        {
            InitializeComponent();
        }

        private void FrmActualizarVehiculo_Load(object sender, EventArgs e)
        {
            Taxis_Palmares.Taxista objTaxista = new Taxis_Palmares.Taxista();
            this.cboTaxista.DataSource = objTaxista.ComboTaxista();

            this.cboTaxista.DisplayMember = "Nombre";
            this.cboTaxista.ValueMember = "Identificacion";
            this.cboTaxista.Text = "Seleccione";

            txtPlaca.Text = VehiculoSeleccionado.Placa.ToString();
            txtCapacidad.Text = VehiculoSeleccionado.Capacidad.ToString();
            txtAno.Text = VehiculoSeleccionado.Ano.ToString();
            txtEstado.Text = VehiculoSeleccionado.Estado;
            txtModelo.Text = VehiculoSeleccionado.Modelo;
            txtTipo.Text = VehiculoSeleccionado.Tipo;
            txtMarca.Text = VehiculoSeleccionado.Marca;
            cboTaxista.Text = VehiculoSeleccionado.Taxista.ToString();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            Gestor objGestor = new Gestor();
            int registrosAfectados = objGestor.ActualizarVehiculo(Convert.ToInt32(txtPlaca.Text), Convert.ToInt32(txtCapacidad.Text), Convert.ToInt32(txtAno.Text), txtEstado.Text, txtModelo.Text, txtTipo.Text, txtMarca.Text, Convert.ToInt32(cboTaxista.SelectedValue));

            if (registrosAfectados >= 0)
            {
                MessageBox.Show("El Vehiculo ha sido Actualizado con exito", "Vehiculo Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo Actualizar el Vehiculo por error de datos", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            objGestor = null;
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textos.SoloLetras(e);
        }
    }
}
