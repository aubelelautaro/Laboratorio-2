using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_11
{
    class Ejercicio_11
    {
        /// <summary>
        ///  Funcion principal.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_11";

            int i, numero, sumaTotal = 0, min = 0, max = 0, flag = 0;
            float promedio;
            bool esValido;

            for(i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el numero {0}: ", (i+1));

                numero = int.Parse(Console.ReadLine());

                while ((esValido = Validacion.Validar(numero, -100, 100) == false))
                {
                    Console.Write("Numero incorrecto: ");
                    numero = int.Parse(Console.ReadLine());
                    esValido = Validacion.Validar(numero, -100, 100);
                }

                sumaTotal += numero;

                if(flag == 0 || numero > max)
                {
                    max = numero;
                }

                if(flag == 0 || numero < min)
                {
                    min = numero;
                    flag = 1;
                }
            }

            promedio = (float)sumaTotal / i;

            Console.WriteLine($"El promedio es: {promedio}, el valor maximo es: {max} y el valor minimo es: {min}");

            Console.ReadKey();
        }
    }
}
