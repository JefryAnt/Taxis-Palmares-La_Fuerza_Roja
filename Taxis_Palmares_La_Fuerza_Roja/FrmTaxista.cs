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
    public partial class FrmTaxista : Form
    {
        //para las dependencias de usuarios
        public Taxis_Palmares.Usuario UserOn { get; set; }

        public FrmTaxista()
        {
            InitializeComponent();
        }

        private void MostrarTaxistas()
        {
            Gestor objGestor = new Gestor();
            gvTaxistas.DataSource = objGestor.ConsultaMasivaTaxista();
            objGestor = null;
        }

        private void FrmTaxista_Load(object sender, EventArgs e)
        {
            MostrarTaxistas();
        }
        
        private void FrmTaxista_Load_1(object sender, EventArgs e)
        {
            btnActualizar.Visible = UserOn.EsAdmin;
            lblACTUALIZAR.Visible = UserOn.EsAdmin;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            MostrarTaxistas();
        }

        private void gvTaxistas_MouseClick(object sender, MouseEventArgs e)
        {
            if (gvTaxistas.CurrentRow != null)
            {
                DataGridViewRow rowActual = gvTaxistas.CurrentRow;
                string IdSeleccionado = rowActual.Cells[0].Value.ToString();
                lblSeleccionado.Text = IdSeleccionado;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarTaxista objAgregar = new FrmAgregarTaxista();
            objAgregar.ShowDialog();
            if (objAgregar.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //Debe mostrar el grid con todos los taxistas para que incluya
                //el recién agregado
                MostrarTaxistas();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (gvTaxistas.CurrentRow != null)
            {
                try
                {
                    int Identificacion = Convert.ToInt32(gvTaxistas.CurrentRow.Cells[0].Value);
                    DateTime Fecha_Nacimineto = DateTime.Parse(gvTaxistas.CurrentRow.Cells[1].Value.ToString());
                    string Nombre = gvTaxistas.CurrentRow.Cells[2].Value.ToString();
                    string Apellido = gvTaxistas.CurrentRow.Cells[3].Value.ToString();
                    string Residencia = gvTaxistas.CurrentRow.Cells[4].Value.ToString();
                    string Telefono = gvTaxistas.CurrentRow.Cells[5].Value.ToString();
                    string Codigo_Taxista = gvTaxistas.CurrentRow.Cells[6].Value.ToString();

                    Taxista objCliente = new Taxista(Identificacion, Fecha_Nacimineto, Nombre, Apellido, Residencia, Telefono, Codigo_Taxista);

                    FrmActualizarTaxista objActualizar = new FrmActualizarTaxista();
                    objActualizar.TaxistaSeleccionado = objCliente;
                    objActualizar.ShowDialog();

                    if (objActualizar.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        MostrarTaxistas();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteTaxista objAplicacion = new FrmReporteTaxista();

            objAplicacion.ShowDialog();
        }

        

    }
}
