using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taxis_Palmares_La_Fuerza_Roja
{
    public partial class frmLogin : Form
    {
        public Taxis_Palmares.Usuario Usuario { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validar();
            
        }

        private void Validar()
        {
            Taxis_Palmares.Usuario myUser = new Taxis_Palmares.Usuario();
            myUser = myUser.Logear(txtUser.Text);
            if (myUser != null)
            {
                if (myUser.Password == txtPass.Text)
                {
                    this.Usuario = myUser;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    MessageBox.Show("Bienvenido(a) " + txtUser.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Clear();
                    txtPass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Validar();
                
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
