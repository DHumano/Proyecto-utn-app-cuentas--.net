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
    public partial class FormExtraer : Form
    {
        private listUser lis;
        private Movimientos mov;
        private string extrac = "extracción";
        private FormMenu formu;

        public FormExtraer()
        {
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            string selected = this.comboBoxCuentas.GetItemText(this.comboBoxCuentas.SelectedItem);

            foreach (var user in lis.usuarios)
            {
                if (user.connect())
                {
                    foreach (var acc in user.cuenta)
                    {
                        if (selected == acc.Cuenta())
                        {
                            try
                            {
                                acc.extraer(Int32.Parse(txtMonto.Text));
                                mov = new Movimientos(user.nom(), acc.Cuenta(), extrac, Int32.Parse(txtMonto.Text));  
                                user.movimientos.Add(mov);
                                MessageBox.Show("La extracción se ha realizado con éxito.");

                                acc.agregar(new Item(Int32.Parse(txtMonto.Text)));
                                
                            }
                            catch (errorOperacion obj1)
                            {
                                MessageBox.Show("El monto supera lo que usted tiene en su cuenta");
                            }
                        }
                    }
                }
            }
            txtMonto.Text = "0";
            Serialize.Serial(lis);
            this.Hide();
            formu = new FormMenu();
            formu.Show();
        }

        private void FormExtraer_Load(object sender, EventArgs e)
        {
            lis = deserialize.Deserializacion();
            txtMonto.Text = "0";
            foreach (var user in lis.usuarios)
            {
                if (user.connect())
                {
                    comboBoxCuentas.DataSource = user.cuenta;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formu = new FormMenu();
            formu.Show();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMonto.MaxLength = 5; 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&    
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
