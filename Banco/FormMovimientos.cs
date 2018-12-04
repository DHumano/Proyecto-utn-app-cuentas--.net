using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{

    public partial class FormMovimientos : Form
    {
        private listUser lis;
        public FormMovimientos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormState.PreviousPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serialize.Serial(lis);
            this.Hide();
            FormState.PreviousPage.Show();
        }

        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            lis = deserialize.Deserializacion();
            int cont = 0;
            foreach (var user in lis.usuarios)
            {
                if (user.connect())
                {
                    for (int i = user.movimientos.Count - 1; i >= 0; i--)
                    {

                        if (cont >= 7)
                        {
                            user.movimientos.Remove(user.movimientos[i]);
                        }
                        cont++;
                    }

                    foreach (var movimiento in user.movimientos)
                    {
                        listBox1.Items.Add(movimiento.mostrarMov());
                    }
                }
            }
        }
    }
}
