using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Serializadora
    {
        public static bool Serializar(IXML ixml)
        {
            return ixml.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\test.xml");
        }

        public static bool Deserializar(IXML ixml, out Object obj)
        {
            return ixml.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\test.xml",out obj);
        }
    }
}
