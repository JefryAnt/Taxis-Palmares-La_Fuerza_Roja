using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taxis_Palmares_La_Fuerza_Roja
{
    public partial class FrmModulos : Form
    {
        //logear y mostrar boton usuario al usuario correcto
        public Taxis_Palmares.Usuario UsuarioConectado { get; set; }

        public FrmModulos()
        {
            InitializeComponent();
        }
        
        private void FrmModulos_Load(object sender, EventArgs e)
        {
            btnUsuario.Visible = UsuarioConectado.EsAdmin;
            lblUsuarios.Visible = UsuarioConectado.EsAdmin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCliente objAplicacion = new FrmCliente();
            objAplicacion.UserOn = this.UsuarioConectado;
            objAplicacion.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmLlamada objAplicacion = new FrmLlamada();

            objAplicacion.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmTarifa objAplicacion = new FrmTarifa();
            objAplicacion.UserOn = this.UsuarioConectado;
            objAplicacion.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVehiculo objAplicacion = new FrmVehiculo();
            objAplicacion.UserOn = this.UsuarioConectado;
            objAplicacion.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmTaxista objAplicacion = new FrmTaxista();
            objAplicacion.UserOn = this.UsuarioConectado;
            objAplicacion.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmFactura objAplicacion = new FrmFactura();

            objAplicacion.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario objAplicacion = new FrmUsuario();

            objAplicacion.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)//boton para salir y cambiar de usuario
        {
            frmLogin myLogin = new frmLogin();
            this.Dispose();
            myLogin.ShowDialog();
            if (myLogin.DialogResult == DialogResult.OK)
            {
                FrmModulos frm = new FrmModulos();
                frm.UsuarioConectado = myLogin.Usuario;
                myLogin.Dispose();
                frm.ShowDialog();
            }
        }

        
    }
}
