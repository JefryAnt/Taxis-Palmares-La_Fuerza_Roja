using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Taxis_Palmares_La_Fuerza_Roja
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin myLogin = new frmLogin();
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
