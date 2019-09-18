using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio_10";
            /**********************************************************
             *    ------------
             *    |   1  | 1 |
             *    |   2  | 3 |
             *    |   3  | 5 |
             *    |   4  | 7 |
             *    |   5  | 9 |             
             *    |   6  | 11|  
             *     ----------
             *     
             *     fil  -  asteriscos
             ***********************************************************/
            Console.Write("Ingrese la altura de la piramide: ");
            int altura = int.Parse(Console.ReadLine());
            int asterisco;
            int espacio;

            Console.Write("\n\n\n\n\n");


            for(int fila = 1; fila <= altura; fila++)
            {
                for(espacio = 1; espacio <= (altura - fila); espacio++)
                {
                    Console.Write(" ");
                }

                for(asterisco = 1; asterisco <= ( (2 * fila) - 1); asterisco++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            Console.Write("\n\nPulse cualquier tecla para salir. . .");
            Console.ReadKey();
        }
    }
}
