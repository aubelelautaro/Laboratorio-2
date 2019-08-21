using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // CENTROS NUMERICOS

            Console.Title = "Ejercicio_05";

            Console.WriteLine("\t\t*****PROGRAMA PARA CALCULAR CENTROS NUMERICOS*****\n\n");
            Console.Write("Ingrese un numero (Entero): ");
            int num = int.Parse(Console.ReadLine());

            while (num < 1)
            {
                Console.Write("Ingrese un numero valido: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.Write("\nLos Numero Que Son Centros Numericos Hasta El {0} Son: \n");

            for(int i = 0; i < num; i++)
            {
                if(EsCentroNumerico((i+1)) == true && i != 0)
                {
                    Console.WriteLine("--> " + (i+1));
                }
            }

            Console.Write("\n\nPulse Cualquier Tecla Para Salir. . .");
            Console.ReadKey();

        }

        static bool EsCentroNumerico(int num)
        {
            int aumento = 1, i, j, sumaAtras= 0, sumaAdelante = 0;

            while(aumento < num)
            {
                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                for(i = 1; i < aumento; i++)
                {
                    sumaAtras += i;
                }

                for(j = aumento + 1; j <= sumaAtras; j++)
                {
                    if((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                    {
                        break;
                    }

                    sumaAdelante += j;
                }
            }

            if (sumaAtras == sumaAdelante)
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
