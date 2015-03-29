using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace Taxis_Palmares_La_Fuerza_Roja
{
    public partial class FrmReporteFactura : Form
    {
        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument reporte = new ReportDocument();
            reporte.Load(@"C:\Datos Taxis Palmares Fuerza Roja\ReporteFactura.rpt");
            reporte.SetDatabaseLogon("sa", "sa", "JEFRY", "DBTaxis_Palmares");
            //users pass server database names.
            reporte.Refresh();
            this.crystalReportViewer1.ReportSource = reporte;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
