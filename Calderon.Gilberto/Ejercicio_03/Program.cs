using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_3";

            int num, i;

            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            for (i = 0; i < num; i++)
            {
                if (esPrimo(i + 1) == true)
                {
                    Console.WriteLine((i + 1)); // Sin los parentesis es igual
                }

            }

            Console.ReadKey();
        }

        static bool esPrimo(int x)
        {
            if (x <= 1)
            {
                return false;
            }

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    
    }
}
