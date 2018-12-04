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
    public partial class Formuser : Form
    {
        private listUser lis;
        private FormMenu m = new FormMenu();
        public Formuser()
        {
            InitializeComponent();
        }

        private void Formuser_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Usuario user = new Usuario("dario", "asd");
            //Usuario user2 = new Usuario("cinthia", "asd");
            //Usuario user3 = new Usuario("vanesa", "asd");
            //Usuario user4 = new Usuario("test", "test");
            //Cuentas cu1 = new Cuentas("cuenta corriente", 0, false);
            //Cuentas cu2 = new Cuentas("cuenta de ahorro", 0, true);
            //Cuentas cu3 = new Cuentas("cuenta corriente", 0, false);
            //Cuentas cu4 = new Cuentas("cuenta de ahorro", 0, true);
            //Cuentas cu5 = new Cuentas("cuenta corriente", 0, false);
            //Cuentas cu6 = new Cuentas("cuenta de ahorro", 0, true);
            //Cuentas cu7 = new Cuentas("cuenta corriente", 0, false);
            //Cuentas cu8 = new Cuentas("cuenta de ahorro", 0, true);
            //user.agregar(cu1);
            //user.agregar(cu2);
            //user2.agregar(cu3);
            //user2.agregar(cu4);
            //user3.agregar(cu5);
            //user3.agregar(cu6);
            //user4.agregar(cu7);
            //user4.agregar(cu8);

            //var list = new listUser();
            //list.agregar(user);
            //list.agregar(user2);
            //list.agregar(user3);
            //list.agregar(user4);


            //Stream flujo = File.Create("usuarios.bin");
            //BinaryFormatter serializer = new BinaryFormatter();
            //serializer.Serialize(flujo, list);
            //flujo.Close();
        }

        private void Formuser_Load(object sender, EventArgs e)
        {
            lis=deserialize.Deserializacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (var item in lis.usuarios)
            {
                if (item.valid(Usuario.Text, Password.Text))                   
                {
                    flag = true;
                    Serialize.Serial(lis);  
                    this.Hide();
                    m.ShowDialog();
                }
            }

            if (!flag)
            {
                MessageBox.Show("Usuario o contraseña incorrecta, intente nuevamente");
                Usuario.Text = "";
                Password.Text = "";
                return;
            }
        }
    }
}
