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
            int opcion;
            string input;
            double numero;

            do
            {
                Console.WriteLine("1 - Conversor Decimal Binario\n2- Conversior Binario Decimal\n3- Salir");
            
                while(!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("DEBE SER NUMERICA");
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un numero Decimal: ");
                        input = Console.ReadLine();

                        while(!double.TryParse(input, out numero))
                        {
                            Console.WriteLine("DEBE SER NUMERICA");
                            Console.Write("Ingrese un numero Decimal: ");
                            input = Console.ReadLine();
                        }

                        Console.WriteLine($"El numero {numero} en binario es: {Conversor.DecimalBinario(numero)}");
                        break;

                        case 2:
                            Console.Write("Ingrese un numero Binario: ");
                            input = Console.ReadLine();

                        Console.WriteLine($"El numero {input} en decimal es : {Conversor.BinarioDecimal(input)}");
                        break;

                    case 3:
                        /*************** SALIR *******************/
                        //
                        //
                        //
                        break;
                }

            } while (opcion != 3);

            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
    }
}
