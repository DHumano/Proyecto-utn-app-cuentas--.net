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
    public partial class FormBienvenido : Form
    {  

        private listUser lis;

        public FormBienvenido()
        {
            InitializeComponent();
        }

        private void FormBienvenido_Load(object sender, EventArgs e)
        {
            lis = deserialize.Deserializacion();
        }

        private void Sesion_Click(object sender, EventArgs e)
        {
            foreach (var user in lis.usuarios)
            {
                user.logout();
            }
            Serialize.Serial(lis);

            Formuser openForm = new Formuser();
            openForm.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }
    }
}
