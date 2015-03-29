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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void MostrarUsuarios()
        {
            Gestor objGestor = new Gestor();
            gvUsuarios.DataSource = objGestor.ConsultaMasivaUsuario();
            objGestor = null;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        
        private void btnCargar_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void gvUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (gvUsuarios.CurrentRow != null)
            {
                DataGridViewRow rowActual = gvUsuarios.CurrentRow;
                string IdSeleccionado = rowActual.Cells[0].Value.ToString();
                lblSeleccionado.Text = IdSeleccionado;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario objAgregar = new FrmAgregarUsuario();
            objAgregar.ShowDialog();
            if (objAgregar.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //Debe mostrar el grid con todos los usuarios para que incluya
                //el recién agregado
                MostrarUsuarios();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (gvUsuarios.CurrentRow != null)
            {
                int idTipoUsuario = 0;
                string idUsuario = gvUsuarios.CurrentRow.Cells[0].Value.ToString();
                string password = gvUsuarios.CurrentRow.Cells[1].Value.ToString();
                string TipoUsuario = gvUsuarios.CurrentRow.Cells[2].Value.ToString();

                switch (TipoUsuario)
                {
                    case "Usuario":
                        idTipoUsuario = 2;
                        break;
                    case "Administrador":
                        idTipoUsuario = 1;
                        break;
                }

                Usuario objUsuario = new Usuario(idUsuario, password, idTipoUsuario);

                FrmActualizarUsuario objActualizar = new FrmActualizarUsuario();
                objActualizar.UsuarioSeleccionado = objUsuario;
                objActualizar.ShowDialog();

                if (objActualizar.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    MostrarUsuarios();
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         

    }
}
