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
    public partial class FormDeposit : Form
    {
        private listUser lis;
        private Movimientos mov;
        private string deposito = "depósito";
        private FormMenu formu;

        public FormDeposit()
        {
            InitializeComponent();
        }

        private void FormDeposit_Load(object sender, EventArgs e)
        {
            lis = deserialize.Deserializacion();
            Monto.Text = "0";

            foreach (var user in lis.usuarios)
            {
                if (user.connect())
                {
                    comboBox1.DataSource = user.cuenta;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            foreach (var user in lis.usuarios)
            {
                if (user.connect())
                {
                    foreach (var acc in user.cuenta)
                    {
                        if (selected == acc.Cuenta()) 
                        {
                            acc.depositar(Int32.Parse(Monto.Text));
                            mov = new Movimientos(user.nom(), acc.Cuenta(), deposito, Int32.Parse(Monto.Text));  
                            user.movimientos.Add(mov);       
                            acc.agregar(new Item(Int32.Parse(Monto.Text)));
                        }
                    }
                }
            }
            MessageBox.Show("Se ha depositado con éxito.");
            Monto.Text = "0";
            Serialize.Serial(lis);
            this.Hide();
            formu = new FormMenu();
            formu.Show();
        }

        private void Monto_KeyPress(object sender, KeyPressEventArgs e)  
        {
            Monto.MaxLength = 5;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formu = new FormMenu();
            formu.Show();
            
        }
    }
}
