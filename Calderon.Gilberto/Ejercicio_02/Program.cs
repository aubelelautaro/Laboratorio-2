using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_2";

            double num;

            Console.Write("Ingrese un numero: ");
            num = float.Parse(Console.ReadLine());

            while (num <= 0)
            {
                Console.Write("Error, REINGRESAR NUMERO!!: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.Write("\n\nEl cuadrado de {0} es {1} y el cubo es {2}", num, Math.Pow(num, 2), Math.Pow(num, 3));

            Console.ReadKey();
        }
    }
}
