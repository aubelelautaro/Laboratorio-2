using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // version del framework 4.6.1
            Console.WriteLine("Hello World!");

            MiClase.edad = 23;
            MiClase.nombre = "Juan";
            MiClase.MostrarEdad();
            string nom = MiClase.RetornarNombre();
            Console.WriteLine(nom);

            MiLibreria.MiClase.nombre = "Gilberto";
            Console.WriteLine(MiLibreria.MiClase.MostrarNombre());

            Console.ReadKey();
        }
    }
}
