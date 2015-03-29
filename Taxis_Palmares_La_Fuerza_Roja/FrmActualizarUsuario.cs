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
    public partial class FrmActualizarUsuario : Form
    {

        #region Propiedades

        public Usuario UsuarioSeleccionado { get; set; }

        #endregion Propiedades


        public FrmActualizarUsuario()
        {
            InitializeComponent();
        }

        private void FrmActualizarUsuario_Load(object sender, EventArgs e)
        {
            Taxis_Palmares.Usuario objUsuario = new Taxis_Palmares.Usuario();
            this.cboidTipoUsuario.DataSource = objUsuario.ComboUsuario();

            this.cboidTipoUsuario.DisplayMember = "Descripcion";
            this.cboidTipoUsuario.ValueMember = "idTipo";
            this.cboidTipoUsuario.Text = "Seleccione";


            txtidUsuario.Text = UsuarioSeleccionado.User;
            txtpassword.Text = UsuarioSeleccionado.Password;
            //cboidTipoUsuario.Text = UsuarioSeleccionado.Tipo.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpassword.Text) && (cboidTipoUsuario.Text != "Seleccione"))
            {
                Gestor objGestor = new Gestor();
                int registrosAfectados = objGestor.ActualizarUsuario(txtidUsuario.Text, txtpassword.Text, Convert.ToInt32(cboidTipoUsuario.SelectedValue));

                if (registrosAfectados >= 0)
                {
                    MessageBox.Show("El Usuario ha sido Actualizado con exito", "Usuario Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo Actualizar el Usuario por error de datos", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
