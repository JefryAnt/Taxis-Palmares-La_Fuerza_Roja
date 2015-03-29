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
    public partial class FrmActualizarTaxista : Form
    {

        #region Propiedades

        public Taxista TaxistaSeleccionado { get; set; }

        #endregion Propiedades


        public FrmActualizarTaxista()
        {
            InitializeComponent();
        }
        
        private void FrmActualizarTaxista_Load(object sender, EventArgs e)
        {

            txtIdentificacion.Text = TaxistaSeleccionado.Identificacion.ToString();
            txtFecha_Nacimineto.Text = TaxistaSeleccionado.Fecha_Nacimineto.ToString();
            txtNombre.Text = TaxistaSeleccionado.Nombre;
            txtApellido.Text = TaxistaSeleccionado.Apellido;
            txtResidencia.Text = TaxistaSeleccionado.Residencia;
            txtTelefono.Text = TaxistaSeleccionado.Telefono;
            txtCodigo_Taxista.Text = TaxistaSeleccionado.Codigo_Taxista;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            Gestor objGestor = new Gestor();
            int registrosAfectados = objGestor.ActualizarTaxista(Convert.ToInt32(txtIdentificacion.Text), Convert.ToDateTime(txtFecha_Nacimineto.Text), txtNombre.Text, txtApellido.Text, txtResidencia.Text, txtTelefono.Text, txtCodigo_Taxista.Text);

            if (registrosAfectados >= 0)
            {
                MessageBox.Show("El Taxista ha sido Actualizado con exito", "Taxista Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo Actualizar el Taxista por error de datos", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            objGestor = null;
            DialogResult = System.Windows.Forms.DialogResult.OK;

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
