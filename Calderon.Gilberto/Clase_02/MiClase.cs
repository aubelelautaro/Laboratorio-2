using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class MiClase
    {
        public static string nombre;
        public static int edad;

        public static void MostrarEdad()
        {
            Console.WriteLine(MiClase.edad);
        }

        public static string RetornarNombre()
        {
            return MiClase.nombre;
        }

        public static bool CompararNombres(string nombre)
        {
            if (MiClase.nombre == nombre)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
