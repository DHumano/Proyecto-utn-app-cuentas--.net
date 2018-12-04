using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    [Serializable]
    class listUser 
    {
        public List<Usuario> usuarios { get; }

        public listUser()
        {
            usuarios = new List<Usuario>();
        }
        public void agregar(Usuario e)
        {
            usuarios.Add(e);
        }
        public void remove(Usuario e)
        {
            usuarios.Remove(e);
        }
    }
}
