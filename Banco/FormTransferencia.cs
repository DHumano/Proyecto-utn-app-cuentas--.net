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
    public partial class FormTransferencia : Form
    {
        private List<Cuentas> listaCuentas = new List<Cuentas>();
        private listUser lis,lisCopia;
        private string transf="Transferencia",transf2= "Transferencia de";
        private MovimientoTransf mov,mov2;
        private FormMenu formu;
        public FormTransferencia()
        {
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            string selected = this.cuentaconectada.GetItemText(this.cuentaconectada.SelectedItem);  
            string selected2 = this.usuarioaenviar.GetItemText(this.usuarioaenviar.SelectedItem);
            string selected3 = this.cuentadeuseraenviar.GetItemText(this.cuentadeuseraenviar.SelectedItem);
            bool flag = false;

            foreach (var user in lis.usuarios)
            {
                if (user.connect())
                {
                    foreach (var acc in listaCuentas) 
                    {
                        if (selected == acc.Cuenta())
                        {
                            try
                            {
                                flag = true;
                                acc.extraer(Int32.Parse(MontoT.Text));
                                mov = new MovimientoTransf(user.nom(), acc.Cuenta(), transf, Int32.Parse(MontoT.Text), selected2);  
                                mov2 = new MovimientoTransf(user.nom(), acc.Cuenta(), transf2, Int32.Parse(MontoT.Text), selected2);  
                                user.movimientos.Add(mov);       
                                acc.agregar(new Item(Int32.Parse(MontoT.Text)));
                            }
                            catch (errorOperacion obj1)
                            {
                                MessageBox.Show("El monto supera lo que usted tiene en su cuenta");
                            }

                        }
                    }
                }
            }
            if (flag)
            {
                foreach (var userd in lis.usuarios)
                {
                    if (selected2 == userd.nom())
                    {
                        userd.movimientos.Add(mov2);     
                        foreach (var acc2 in userd.cuenta)
                        {
                            if (selected3 == acc2.Cuenta())
                            {
                                acc2.depositar(Int32.Parse(MontoT.Text));
                                acc2.agregar(new Item(Int32.Parse(MontoT.Text)));
                            }
                        }
                    }
                }
                MessageBox.Show("La transferencia se ha realizado con éxito.");
            }

            Serialize.Serial(lis);
            MontoT.Text = "0";
            this.Hide();
            formu = new FormMenu();
            formu.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formu = new FormMenu();
            formu.Show();
        }

        private void FormTransferencia_Load(object sender, EventArgs e)
        {
            lis = deserialize.Deserializacion();
            lisCopia = lis;
            foreach (var user in lis.usuarios)
            {    
                if (user.connect())
                {
                    foreach (var acc in user.cuenta)
                    {
                        listaCuentas.Add(acc);
                    }
                    cuentaconectada.DataSource = listaCuentas;
                }
            }
            usuarioaenviar.DataSource = lis.usuarios;
        }

        private void usuarioaenviar_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string selected2 = this.usuarioaenviar.GetItemText(this.usuarioaenviar.SelectedItem);

            foreach (var user in lis.usuarios)
            {
                if (selected2 == user.nom())
                {
                    cuentadeuseraenviar.DataSource = user.cuenta;
                }
            }
        }
    }
}