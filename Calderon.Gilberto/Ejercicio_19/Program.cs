using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador();

            s1.Sumar("Ciao", "Ciao");
            s2.Sumar(long.MinValue, long.MaxValue);
            Console.WriteLine(s1 | s2);
            Console.WriteLine($"{s1+s2} ---- {(int)s1} ---- {(int)s2}");
            
            Console.ReadKey(true);
        }
    }
}
