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
    public partial class FrmCliente : Form
    {
        //para las dependencias de usuarios
        public Taxis_Palmares.Usuario UserOn { get; set; }

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void MostrarClientes()
        {
            Gestor objGestor = new Gestor();
            gvClientes.DataSource = objGestor.ConsultaMasivaCliente();
            objGestor = null;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        
        
        private void FrmCliente_Load_1(object sender, EventArgs e)
        {
            btnActualizar.Visible = UserOn.EsAdmin;
            lblACTUALIZAR.Visible = UserOn.EsAdmin;
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void gvClientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (gvClientes.CurrentRow != null)
            {
                DataGridViewRow rowActual = gvClientes.CurrentRow;
                string IdSeleccionado = rowActual.Cells[0].Value.ToString();
                lblSeleccionado.Text = IdSeleccionado;
            }
        } 

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente objAgregar = new FrmAgregarCliente();
            objAgregar.ShowDialog();
            if (objAgregar.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //Debe mostrar el grid con todos los clientes para que incluya
                //el recién agregado
                MostrarClientes();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (gvClientes.CurrentRow != null)
            {
                int Cedula = Convert.ToInt32(gvClientes.CurrentRow.Cells[0].Value.ToString());
                string Nombre = gvClientes.CurrentRow.Cells[1].Value.ToString();
                string Apellido = gvClientes.CurrentRow.Cells[2].Value.ToString();
                string Telefono = gvClientes.CurrentRow.Cells[3].Value.ToString();
                string Direccion = gvClientes.CurrentRow.Cells[4].Value.ToString();

                Cliente objCliente = new Cliente(Cedula, Nombre, Apellido, Telefono, Direccion);

                FrmActualizarCliente objActualizar = new FrmActualizarCliente();
                objActualizar.ClienteSeleccionado = objCliente;
                objActualizar.ShowDialog();

                if (objActualizar.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    MostrarClientes();
                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
   

    }
}
