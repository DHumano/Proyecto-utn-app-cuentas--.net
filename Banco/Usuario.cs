using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Banco
{
    [Serializable]
    class Usuario
    {
        private string nombre;
        private string contraseña;
        public List<Cuentas> cuenta { get; }
        public List<Movimientos> movimientos { get; }
        public bool conectado;
        
        public Usuario(string n, string c)
        {
            this.nombre = n;
            this.contraseña = c;
            cuenta = new List<Cuentas>();
            movimientos = new List<Movimientos>();
        }

        public void agregar(Cuentas e)
        {
            cuenta.Add(e);
        }
        
        public string nom()            
        {
            return nombre;
        }

        public string con()        
        {
            return contraseña;
        }

        public bool valid(string a,string b)        
        {
            if (a == nombre && b == contraseña)
            {
                conectado = true;
                return conectado;
            }
            else return false;
        }

        public bool connect()       
        {
            return conectado;
        }
        
        public bool logout()        
        {
            conectado = false;
            return conectado;
        }

        public bool login()        
        {
            conectado = true;
            return conectado;
        }
        
        public override string ToString()
        {
            return nombre;
        }
    }
}
