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
    public partial class FrmAgregarTarifa : Form
    {
        public FrmAgregarTarifa()
        {
            InitializeComponent();
        }
        
        
        private void FrmAgregarTarifa_Load(object sender, EventArgs e)
        {
            Taxis_Palmares.Tarifa objtarifa = new Tarifa();
            this.txtId_Tarifas.Text = objtarifa.numeroTarifa().ToString();
            txtId_Tarifas.ReadOnly = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId_Tarifas.Text) && !string.IsNullOrEmpty(txtMonto.Text) && !string.IsNullOrEmpty(txtLugar.Text) && !string.IsNullOrEmpty(txtDistancia.Text) && !string.IsNullOrEmpty(txtExtras.Text))
            {
                Gestor objGestor = new Gestor();
                int registrosAfectados = objGestor.AgregarTarifa(Convert.ToInt32(txtId_Tarifas.Text), Convert.ToDecimal(txtMonto.Text), txtLugar.Text, txtDistancia.Text, txtExtras.Text);


                if (registrosAfectados > 0)
                {
                    MessageBox.Show("La Tarifa ha sido  Agregada con exito", "Tarifa Guardada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la Tarifa ya que hay otra Tarifa con este ID", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
