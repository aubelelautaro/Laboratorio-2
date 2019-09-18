using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_09";

            int altura;
            int reset = 0;
            int asteriscos = 1;


            Console.Write("Ingrese la altura de la piramide: ");
            altura = int.Parse(Console.ReadLine());

            for (int i = 1; i <= altura; i++)
            {
                while(reset < asteriscos)
                {
                    Console.Write("*");
                    reset++;
                }

                Console.Write("\n");
                reset = 0;
                asteriscos += 2;
            }


            Console.ReadKey();
            
        }
    }
}
