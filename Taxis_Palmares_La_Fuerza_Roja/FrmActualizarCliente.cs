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
    public partial class FrmActualizarCliente : Form
    {

        #region Propiedades

        public Cliente ClienteSeleccionado { get; set; }

        #endregion Propiedades


        public FrmActualizarCliente()
        {
            InitializeComponent();
        }

        private void FrmActualizarCliente_Load(object sender, EventArgs e)
        {

            txtCedula.Text = ClienteSeleccionado.Cedula.ToString();
            txtNombre.Text = ClienteSeleccionado.Nombre;
            txtApellido.Text = ClienteSeleccionado.Apellido;
            txtTelefono.Text = ClienteSeleccionado.Telefono;
            txtDireccion.Text = ClienteSeleccionado.Direccion;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            Gestor objGestor = new Gestor();
            int registrosAfectados = objGestor.ActualizarCliente(Convert.ToInt32(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text);

            if (registrosAfectados >= 0)
            {
                MessageBox.Show("El Cliente ha sido Actualizado con exito", "Cliente Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo Actualizar el Cliente por error de datos", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
