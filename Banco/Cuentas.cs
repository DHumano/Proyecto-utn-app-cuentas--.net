using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{    [Serializable]
    class Cuentas
    {
        private string cuenta;
        private int valor;
        private bool tipo;
        public List<ObservadorMontoTotal> omt;
        public List<Item> items;

        public Cuentas(string c, int v, bool t)
            {
                omt = new List<ObservadorMontoTotal>();
                items = new List<Item>();
                this.cuenta = c;
                this.valor = v;
                this.tipo = t;
            }

        public void agregarObservadorMontoTotal(ObservadorMontoTotal observador)
        {
            omt.Add(observador);
        }

        public void notificarObservadores()
        {
            foreach (ObservadorMontoTotal unObservador in omt)
            {
                unObservador.NotificarMontoTotal(Valor());
            }
        }

        public void agregar(Item e)
        {
            items.Add(e);
            notificarObservadores();
        }

        public int GetValor()
        {
            int a = valor;
            int total = 0;
            foreach (var item in items)
            {
                total += item.Monto;
            }

            return total;  
        } 

        public void depositar(int Monto)
        {
            valor = valor + Monto;
            notificarObservadores();
        }
            public void extraer(int txtMonto)
        {
            if (!tipo) 
            {
                valor = valor - txtMonto;
                notificarObservadores();
            }
            if (tipo && (valor - txtMonto) >= 0)   
            {
                valor = valor - txtMonto;
                notificarObservadores();
            }
            else if (tipo && (valor - txtMonto) < 0)
            {
                throw new errorOperacion();   
            }

        }
            public bool Tipo()  
        {
            return tipo;
        }
            public string Cuenta()
        {
            return cuenta;
        }

        public override string ToString()
        {
            return cuenta;
        }

        public int Valor()
        {
            return valor;
        }

    }
    class errorOperacion : Exception { }

}

