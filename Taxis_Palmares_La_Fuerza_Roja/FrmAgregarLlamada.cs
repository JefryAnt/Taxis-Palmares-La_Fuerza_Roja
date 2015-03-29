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
    public partial class FrmAgregarLlamada : Form
    {
        public FrmAgregarLlamada()
        {
            InitializeComponent();
        }

        private void FrmAgregarLlamada_Load(object sender, EventArgs e)
        {
            
            Taxis_Palmares.Llamada objLlamada = new Llamada();
            this.txtCodigo.Text = objLlamada.numeroLlamada().ToString();
            txtCodigo.ReadOnly = true;
            
            this.txtNombreCliente.Enabled = false;
            comboVehiculo();
            comboCliente();
            
        }

        private void comboCliente()
        {
            try
            {
                Taxis_Palmares.Cliente objCliente = new Taxis_Palmares.Cliente();
                this.cboCliente.DataSource = objCliente.ComboCliente();

                this.cboCliente.DisplayMember = "Nombre";
                this.cboCliente.ValueMember = "Cedula";
                this.cboCliente.Text = "Seleccione";

            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese primero al menos un cliente");
            }
            
        }

        private void comboVehiculo()
        {
            try
            {
                Taxis_Palmares.Vehiculo objVehiculo = new Taxis_Palmares.Vehiculo();
                this.cboVehiculo.DataSource =objVehiculo.ConsultaMasivaVehiculo();

                this.cboVehiculo.DisplayMember = "Placa";
                this.cboVehiculo.ValueMember = "Placa";
                this.cboVehiculo.Text = "Seleccione";

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese primero al menos un vehiculo");
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) && !string.IsNullOrEmpty(txtHora.Text) && !string.IsNullOrEmpty(txtDireccion.Text) && (cboCliente.Text != "Seleccione") && !string.IsNullOrEmpty(txtNombreCliente.Text) && (cboVehiculo.Text != "Seleccione"))
            {
                Gestor objGestor = new Gestor();
                int registrosAfectados = objGestor.AgregarLlamada(Convert.ToInt32(txtCodigo.Text), txtHora.Text, txtDireccion.Text, Convert.ToInt32(cboCliente.SelectedValue), txtNombreCliente.Text, Convert.ToInt32(cboVehiculo.SelectedValue));


                 if (registrosAfectados > 0)
                 {
                     MessageBox.Show("La Llamada ha sido  Agregada con exito", "Llamada Guardada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else
                 {
                    MessageBox.Show("No se pudo guardar la Llamada", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void cboCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCliente.Text == "Desconocido Desconocido")
            {
                this.txtNombreCliente.Enabled = true;
            }
            else
            {
                this.txtNombreCliente.Enabled = false;
            }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textos.SoloLetras(e);
        }

    }
}
