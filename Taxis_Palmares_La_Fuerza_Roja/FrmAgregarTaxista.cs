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
    public partial class FrmAgregarTaxista : Form
    {
        public FrmAgregarTaxista()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdentificacion.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtResidencia.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtCodigo_Taxista.Text))
            {
                Gestor objGestor = new Gestor();
                int registrosAfectados = objGestor.AgregarTaxista(Convert.ToInt32(txtIdentificacion.Text), Convert.ToDateTime(txtFecha_Nacimineto.Text), txtNombre.Text, txtApellido.Text, txtResidencia.Text, txtTelefono.Text, txtCodigo_Taxista.Text);


                if (registrosAfectados > 0)
                {
                    MessageBox.Show("El Taxista ha sido  Agregado con exito", "Taxista Guardado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Taxista ya que hay otro taxista con esta Identificacion", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
