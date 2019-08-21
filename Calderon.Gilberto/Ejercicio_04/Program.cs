using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_04";

            Console.WriteLine("*****PROGRAMA PARA HALLAR LOS CUATRO PRIMEROS NUMEROS PERFECTOS*****");
            Console.ReadKey();

           // Program p = new Program();

            int count = 0, i;

            for (i = 0; i < 20; i++)
            {
                if (EsPerfecto(i + 1) == true || count != 5)
                {
                    Console.WriteLine((i + 1));

                }
            }

            Console.ReadKey();

        }

        static bool EsPerfecto(int x)
        {
            int i, sum = 0;

            for (i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == x)
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
