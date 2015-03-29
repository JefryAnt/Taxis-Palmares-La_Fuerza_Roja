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
    public partial class FrmAgregarCliente : Form
    {
        public FrmAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCedula.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtDireccion.Text))
            {
                Gestor objGestor = new Gestor();
                int registrosAfectados = objGestor.AgregarCliente(Convert.ToInt32(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text);

                if (registrosAfectados > 0)
                {
                    MessageBox.Show("El Cliente ha sido Agregado con exito", "Cliente Guardado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente ya que hay otro cliente con esta cedula", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textos.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Textos.SoloLetras(e);
        }
    }
}
