using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_06";

            Console.Write("\t\t*****PROGRAMA PARA DETERMINAR LOS ANIOS BISIESTOS EN UN RANGO*****\n\n\n");

            Console.Write("Ingrese un anio de inicio: ");
            int anio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un anio de fin: ");
            int anio2 = int.Parse(Console.ReadLine());

            for(;  anio <= anio2; anio++)
            {
                 if (anio % 4 == 0 || ((anio % 100 == 0) && (anio % 400 == 0)))
                 {
                     Console.WriteLine("{0} ES BISIESTO", anio);
                 }
                 else
                 {
                     Console.WriteLine("{0} NO ES BISIESTO", anio);
                 }
              
            }

            Console.WriteLine("\n\nFIN DEL PROGRAMA. . .");
            Console.ReadKey();

        }
    }
}
