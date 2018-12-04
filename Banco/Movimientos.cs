using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    [Serializable]
    class Movimientos
    {
        private string usuario;
        private string cuenta;
        private string operacion;
        private string fecha;
        private string info;
        private int monto;

        public Movimientos(string u, string c, string o, int m)
        {
            this.usuario = u;
            this.cuenta = c;
            this.operacion = o;
            this.monto = m;
            this.fecha = DateTime.Now.ToString("yyyy-MM-dd / HH:mm:ss");
        }

        public virtual string mostrarMov()
        {
            info = usuario + " / Operacion: " + operacion + "-" + " - Monto: $" + monto+" en " +cuenta +" /registro horario:"+ fecha;
            return info;
        }
    }
}
