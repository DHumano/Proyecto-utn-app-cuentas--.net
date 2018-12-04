using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    class TextBoxObservador : TextBox, ObservadorMontoTotal
    {
        public void NotificarMontoTotal(int valor)
        {
            this.Text = valor.ToString();
        }
    }
}
