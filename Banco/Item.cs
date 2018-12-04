using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{   [Serializable]
    public class Item
    {
        public int Monto { get; set; }

        public Item(int valor)
        {
            this.Monto = valor;
        }

        public override string ToString()
        {
            return Monto.ToString();
        }
    }
}
