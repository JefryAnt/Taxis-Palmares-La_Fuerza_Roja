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
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtidUsuario.Text) && !string.IsNullOrEmpty(txtpassword.Text) && (cboidTipoUsuario.Text != "Seleccione"))
            {
                Gestor objGestor = new Gestor();
                int registrosAfectados = objGestor.AgregarUsuario(txtidUsuario.Text, txtpassword.Text, Convert.ToInt32(cboidTipoUsuario.SelectedValue));

                if (registrosAfectados > 0)
                {
                    MessageBox.Show("El Usuario ha sido Agregado con exito", "Usuario Guardado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Usuario ya que hay otro Usuario con esta ID", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            ComboUsuario();
        }

        private void ComboUsuario()
        {
            try
            {

                Taxis_Palmares.Usuario objUsuario = new Taxis_Palmares.Usuario();
                this.cboidTipoUsuario.DataSource = objUsuario.ComboUsuario();

                this.cboidTipoUsuario.DisplayMember = "Descripcion";
                this.cboidTipoUsuario.ValueMember = "idTipo";
                this.cboidTipoUsuario.Text = "Seleccione";

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese primero al menos un Usuario");
            }

        }
    }
}
