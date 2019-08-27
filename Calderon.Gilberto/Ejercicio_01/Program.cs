using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
                Console.Title = "Ejercicio_01";
               /* Console.WriteLine("Hola Mundo c#");

                string nombre;
                string apellido = "Calderon";

                nombre = Console.ReadLine();
                Console.WriteLine(nombre);
                Console.WriteLine(apellido);
                */

            int sum = 0, num, max = 0, min = 0, i;
            int flag = 0;
            float promedio;


            for (i = 0; i < 5; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;

                if (flag == 0 || max < num)
                {
                    max = num;
                }

                if (flag == 0 || min > num)
                {
                    min = num;
                    flag = 1;
                }
            }

            promedio = (float)sum / i;

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("El maximo es: {0}", max);
            Console.WriteLine("El minimo es: {0}", min);
            Console.ReadKey();
        }
    }
}
