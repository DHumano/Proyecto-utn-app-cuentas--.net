using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    [Serializable]
    class MovimientoTransf :Movimientos
    {
        private string usuario;
        private string cuenta;
        private string operacion;
        private string fecha;
        private string info;
        private int monto;
        private string usuario2;

        public MovimientoTransf(string u, string c, string o, int m,string u2):base(u,c,o,m)
        {
            this.usuario = u;
            this.cuenta = c;
            this.operacion = o;
            this.monto = m;
            this.fecha = DateTime.Now.ToString("yyyy-MM-dd / HH:mm:ss");
            this.usuario2 = u2;
        }

        public override string mostrarMov()
        {
            info = "Operacion: " + operacion +" - "+ usuario +" para "+usuario2+ " - Monto: $" + monto + " en " + cuenta + " /registro horario:" + fecha;
            return info;
        }
    }
}
