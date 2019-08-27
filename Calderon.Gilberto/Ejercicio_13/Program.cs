using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_13";

            double numero;
            string binario;
            char opcion;
            Console.WriteLine("***********CONVERSOR**********************\n\n");

            
            Console.Write("1- Conversor Decimal binario\n");
            Console.Write("2- Conversor Binario Decimal\n");
            opcion = Console.ReadKey().KeyChar;

            switch (opcion)
            {
                case '1':
                    Console.Write("Ingrese un numero decimal: ");
                    numero = double.Parse(Console.ReadLine());

                    Console.WriteLine($"\n\nEl numero ingresado es: \n");
                    char[] retorno = Conversor.DecimalBinario(numero).ToCharArray();

                    for (int i = 0; i < retorno.Length; i++)
                    {
                        Console.Write($"{retorno[i]}");
                    }
                    break;

                case '2':
                    Console.Write("Ingrese un numero binario: ");
                    binario = Console.ReadLine();

                    Console.WriteLine($"\n\nEl numero ingresado es: \n");
                    binario =  Conversor.BinarioDecimal(binario).ToString();
                    Console.WriteLine($"{binario}");

                    break;

                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
            
            

            Console.Write("\n\nPresione enter para salir. . .");
            while (Console.ReadKey().KeyChar != 13) ;
        }
    }
}
