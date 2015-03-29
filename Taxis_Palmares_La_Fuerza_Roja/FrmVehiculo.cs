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
    public partial class FrmVehiculo : Form
    {
        //para las dependencias de usuarios
        public Taxis_Palmares.Usuario UserOn { get; set; }

        public FrmVehiculo()
        {
            InitializeComponent();
        }

        private void MostrarVehiculos()
        {
            Gestor objGestor = new Gestor();
            gvVehiculos.DataSource = objGestor.ConsultaMasivaVehiculo();
            objGestor = null;
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            MostrarVehiculos();
        }
        
        private void FrmVehiculo_Load_1(object sender, EventArgs e)
        {
            btnActualizar.Visible = UserOn.EsAdmin;
            lblACTUALIZAR.Visible = UserOn.EsAdmin;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            MostrarVehiculos();
        }

        private void gvVehiculos_MouseClick(object sender, MouseEventArgs e)
        {
            if (gvVehiculos.CurrentRow != null)
            {
                DataGridViewRow rowActual = gvVehiculos.CurrentRow;
                string IdSeleccionado = rowActual.Cells[0].Value.ToString();
                lblSeleccionado.Text = IdSeleccionado;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarVehiculo objAgregar = new FrmAgregarVehiculo();
            objAgregar.ShowDialog();
            if (objAgregar.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //Debe mostrar el grid con todos los vehiculos para que incluya
                //el recién agregado
                MostrarVehiculos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (gvVehiculos.CurrentRow != null)
            {
                int Placa = Convert.ToInt32(gvVehiculos.CurrentRow.Cells[0].Value.ToString());
                int Capacidad = Convert.ToInt32(gvVehiculos.CurrentRow.Cells[1].Value.ToString());
                int Ano = Convert.ToInt32(gvVehiculos.CurrentRow.Cells[2].Value.ToString());
                string Estado = gvVehiculos.CurrentRow.Cells[3].Value.ToString();
                string Modelo = gvVehiculos.CurrentRow.Cells[4].Value.ToString();
                string Tipo = gvVehiculos.CurrentRow.Cells[5].Value.ToString();
                string Marca = gvVehiculos.CurrentRow.Cells[6].Value.ToString();
                int Taxista = Convert.ToInt32(gvVehiculos.CurrentRow.Cells[7].Value.ToString());

                Vehiculo objVehiculo = new Vehiculo(Placa, Capacidad, Ano, Estado, Modelo, Tipo, Marca, Taxista);

                FrmActualizarVehiculo objActualizar = new FrmActualizarVehiculo();
                objActualizar.VehiculoSeleccionado = objVehiculo;
                objActualizar.ShowDialog();

                if (objActualizar.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    MostrarVehiculos();
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteVehiculo objAplicacion = new FrmReporteVehiculo();

            objAplicacion.ShowDialog();
        }

        

    }
}
