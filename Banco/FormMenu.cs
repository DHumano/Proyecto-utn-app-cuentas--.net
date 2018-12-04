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
    public partial class FormMenu : Form 
    {
        private FormConsultaSaldo consulta;
        private FormExtraer ext;
        private FormDeposit dep;
        private FormTransferencia transf;
        private FormMovimientos mov;
        private FormBienvenido inicio = new FormBienvenido();
        private listUser lis;
        

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            lis = deserialize.Deserializacion();
            int i = 50;
            foreach (var user in lis.usuarios)
            {
                if (user.connect())
                {
                    usuario.Text=user.nom();
                    foreach (var acc in user.cuenta)
                    {
                        TextBoxObservador textBox = new TextBoxObservador();
                        textBox.Name = "textBox" + acc.ToString();
                        this.Controls.Add(textBox);

                        acc.agregarObservadorMontoTotal(textBox); 
                        acc.notificarObservadores();

                        textBox.Location = new Point(180, 260 + i);
                        Label label = new Label();
                        label.Text = acc.ToString();
                        this.Controls.Add(label);
                        label.Location = new Point(80, 265 + i);
                        i += 50;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormState.PreviousPage = this;
            ext = new FormExtraer();
            this.Close();
            ext.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lis = deserialize.Deserializacion();
            this.Hide();
            FormState.PreviousPage = this;
            dep = new FormDeposit();
            this.Close();
            dep.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("¿Desea cerrar sesión? ", "Cierre de sesión", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                foreach (var user in lis.usuarios)
                {
                       user.logout(); 
                }
                this.Hide();
                inicio.Show();
                }
        }
        
        private void transferirButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormState.PreviousPage = this;
            transf = new FormTransferencia();
            this.Close();
            transf.Show();
        }

        private void movimButton_Click(object sender, EventArgs e)
        {
            lis = deserialize.Deserializacion();
            this.Hide();
            FormState.PreviousPage = this;
            mov = new FormMovimientos();
            mov.Show();
        }
    }
}
