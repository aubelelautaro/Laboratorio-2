using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_12";
            int sumaTotal = 0;
            char resp;
            int numero;

            for(; ; )
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                /*******************************************************/
                sumaTotal += numero;
                /********************************************************/
                Console.Write("Continuar? (S/N): ");
                resp = Console.ReadKey().KeyChar;

                Console.WriteLine("");
                if(ValidarRespuesta.ValidarS_N(resp))
                {
                    continue;
                }
                else
                {
                    break ;
                }

            }

            Console.Clear();
            Console.Write($"\n\nLa suma total es: {sumaTotal}\n");

            Console.Write("Presione enter para salir. . .");
            while (Console.ReadKey().KeyChar != 13) ;
                
            
        }
    }
}
