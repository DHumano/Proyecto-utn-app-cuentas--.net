using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Banco
{
    static class deserialize
    {
        private static listUser lista;
        public static listUser Deserializacion() {
           
        if (File.Exists("usuarios.bin"))
        {
            Stream flujo2 = File.OpenRead("usuarios.bin");
        BinaryFormatter deserializer = new BinaryFormatter();
        lista = (listUser) deserializer.Deserialize(flujo2);
        flujo2.Close();
        
        }
            return lista;
        }
    }

}