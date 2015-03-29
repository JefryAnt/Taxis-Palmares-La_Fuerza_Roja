using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taxis_Palmares_La_Fuerza_Roja
{
    class Textos
    {
        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("solamente se pueden digitar letras");
            }
        }
    }
}
