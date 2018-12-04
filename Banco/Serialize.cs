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
    static class Serialize
    {
        public static void Serial(listUser list)
        {
            Stream flujo = File.Create("usuarios.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo, list);
            flujo.Close();
        }

    }
}
