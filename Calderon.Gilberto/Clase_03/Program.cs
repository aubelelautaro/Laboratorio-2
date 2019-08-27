using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona("Gilberto", "Calderon", 95854894);
            Console.WriteLine(per.Mostrar());

            Persona otraPersona = new Persona("Pepito", "Perez", 415864896);
            Console.WriteLine(otraPersona.Mostrar());

            Console.ReadKey();
        }
    }
}
