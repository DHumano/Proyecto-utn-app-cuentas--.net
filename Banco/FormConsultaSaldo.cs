using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Banco
{
    public partial class FormConsultaSaldo : Form
    {
        private listUser lis;

        public FormConsultaSaldo()
        {
            InitializeComponent();
        }

        private void FormConsultaSaldo_Load(object sender, EventArgs e)
        {
            lis = deserialize.Deserializacion();
            int i = 50;

            foreach (var user in lis.usuarios)
            {

                if (user.connect())
                {
                    foreach (var acc in user.cuenta)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Text = acc.Valor().ToString();
                        textBox.Name = "textBox" + acc.ToString();
                        this.Controls.Add(textBox);
                        textBox.Location = new Point(180, 100 + i);
                        Label label = new Label();
                        label.Text = acc.ToString();
                        this.Controls.Add(label);
                        label.Location = new Point(50, 105 + i);
                        i += 80;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serialize.Serial(lis);                                         
            this.Hide();
            FormState.PreviousPage.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormState.PreviousPage.Show();
        }
    }
}
