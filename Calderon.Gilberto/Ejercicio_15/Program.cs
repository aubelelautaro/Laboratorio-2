using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Ejercico_15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_15";
            char respuesta;
            double numero1;
            double numero2;
            double resultado;
            char operacion;

            
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t*****Calculadora*****\n\n");
                Console.Write("Ingrese el primer numero: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                numero2 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese una operaccion, + (suma), - (resta), * (multiplicacion), / (division): ");
                operacion = Console.ReadKey().KeyChar;

                resultado = Calculadora.Calcular(numero1, numero2, operacion);

                Console.WriteLine($"\nEl resultado de la operacion es: {resultado}");

                Console.Write("Quiere realizar otra operacion? S/N: ");
               
                respuesta = Console.ReadKey().KeyChar;
            }
            while (!(respuesta == 'N' || respuesta == 'n'));

            Console.Write("\n\nPulse enter para salir. . .");
            while (Console.ReadKey().KeyChar != 13) ;
        }
    }
}
