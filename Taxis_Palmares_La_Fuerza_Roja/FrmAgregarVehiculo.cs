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
    public partial class FrmAgregarVehiculo : Form
    {
        public FrmAgregarVehiculo()
        {
            InitializeComponent();
        }
        
        
        private void FrmAgregarVehiculo_Load(object sender, EventArgs e)
        {
            ComboTaxista();
        }

        private void ComboTaxista()
        {
            try
            {
            
                Taxis_Palmares.Taxista objTaxista = new Taxis_Palmares.Taxista();
                this.cboTaxista.DataSource = objTaxista.ComboTaxista();

                this.cboTaxista.DisplayMember = "Nombre";
                this.cboTaxista.ValueMember = "Identificacion";
                this.cboTaxista.Text = "Seleccione";

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese primero al menos un taxista");
            }
            
        }


        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPlaca.Text) && !string.IsNullOrEmpty(txtCapacidad.Text) && !string.IsNullOrEmpty(txtAno.Text) && !string.IsNullOrEmpty(txtEstado.Text) && !string.IsNullOrEmpty(txtModelo.Text) && !string.IsNullOrEmpty(txtTipo.Text) && !string.IsNullOrEmpty(txtMarca.Text) && (cboTaxista.Text != "Seleccione"))
            {
                Gestor objGestor = new Gestor();
                int registrosAfectados = objGestor.AgregarVehiculo(Convert.ToInt32(txtPlaca.Text), Convert.ToInt32(txtCapacidad.Text), Convert.ToInt32(txtAno.Text), txtEstado.Text, txtModelo.Text, txtTipo.Text, txtMarca.Text, Convert.ToInt32(cboTaxista.SelectedValue));


                if (registrosAfectados > 0)
                {
                    MessageBox.Show("El Vehiculo ha sido  Agregado con exito", "Vehiculo Guardado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Vehiculo ya que hay otro Vehiculo con esta placa", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                objGestor = null;

                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            

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
