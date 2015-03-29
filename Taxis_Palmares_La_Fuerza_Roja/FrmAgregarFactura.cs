using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taxis_Palmares;

namespace Taxis_Palmares_La_Fuerza_Roja
{
    public partial class FrmAgregarFactura : Form
    {
        public FrmAgregarFactura()
        {
            InitializeComponent();
        }

        private void FrmAgregarFactura_Load(object sender, EventArgs e)
        {
            ComboVehiculo();

            ComboTaxista();

            Taxis_Palmares.Factura objFactura = new Factura();
            this.txtNumero_Factura.Text = objFactura.NumeroFactura().ToString();
            txtNumero_Factura.ReadOnly = true;
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

        private void ComboVehiculo()
        {
            try
            {
                Taxis_Palmares.Vehiculo objVehiculo = new Taxis_Palmares.Vehiculo();
                this.cboVehiculo.DataSource = objVehiculo.ConsultaMasivaVehiculo();
                this.cboVehiculo.DisplayMember = "Placa";
                this.cboVehiculo.ValueMember = "Placa";
                this.cboVehiculo.Text = "Seleccione";
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese al menos un Vehiculo");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMonto.Text) && !string.IsNullOrEmpty(txtDetalles.Text) && (cboVehiculo.Text != "Seleccione") && (cboTaxista.Text != "Seleccione"))
            {
                Gestor objGestor = new Gestor();
                int registrosAfectados = objGestor.AgregarFactura(Convert.ToInt32(txtNumero_Factura.Text), Convert.ToDecimal(txtMonto.Text), Convert.ToDateTime(txtFecha.Text), txtDetalles.Text, Convert.ToInt32(cboVehiculo.SelectedValue), Convert.ToInt32(cboTaxista.SelectedValue));


                if (registrosAfectados > 0)
                {
                    MessageBox.Show("La Factura ha sido  Agregada con exito", "Factura Guardada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la Factura", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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


    }
}
