#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_06.Entidades;
#endregion

namespace Clase_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Probando logica.";
            Paleta paleta = 3;

            Tempera tempera1 = new Tempera(ConsoleColor.Red, "a", 2);
            Tempera tempera2 = new Tempera(ConsoleColor.Green, "b", 7);
            Tempera tempera3 = new Tempera(ConsoleColor.Red, "c", 1);
            Tempera tempera4 = new Tempera(ConsoleColor.DarkYellow, "d", 55);
            Tempera[] arrayTemperas = { tempera1, tempera2, tempera3, tempera4 };

            Console.WriteLine($"Se crearon las siguientes temperas: {(string )tempera1}, {(string)tempera2}, {(string)tempera3}, {(string)tempera4} ");
            Pausa();
            Console.Clear();

            Console.WriteLine($"Estado actual de la \'Paleta\'\n{(string)paleta}");
            Pausa();
            Console.Clear();

           
            for(int i = 0; i < 4; i++)
            {
                paleta += arrayTemperas[i];
            }

            Console.WriteLine("Agrego las temperas a la paleta !!!");
            Pausa();
            Console.Clear();

            Console.WriteLine("Resultado:");
            if (paleta == tempera1)
            {
                Console.WriteLine("tempera1 esta dentro de la paleta");
            }
            else
            {
                Console.WriteLine("tempera1 no esta dentro de la paleta");
            }
            if(paleta == tempera2)
            {
                Console.WriteLine("tempera2 esta dentro de la paleta");
            }
            else
            {
                Console.WriteLine("tempera2 no esta dentro de la paleta");
            }
            if (paleta == tempera3)
            {
                Console.WriteLine("tempera3 esta dentro de la paleta");
            }
            else
            {
                Console.WriteLine("tempera3 no esta dentro de la paleta");
            }
            if(paleta == tempera4)
            {
                Console.WriteLine("tempera4 esta dentro de la paleta");
            }
            else
            {
                Console.WriteLine("tempera4 no esta dentro de la paleta");
            }
            Pausa();
            Console.Clear();

            Console.WriteLine("Muestro la paleta: ");
            Console.WriteLine((string)paleta);
            Pausa();

            // quito temperas 

            paleta -= tempera1;
            paleta -= tempera2;
            paleta -= tempera3;
            /***********************/

            Console.Clear();
            Console.WriteLine("QUITO TEMPERAS");
            Console.WriteLine((string)paleta);
            Pausa();
            //paleta -= tempera1;
            //paleta -= tempera2;
            //paleta -= tempera3;
            //Console.Clear();
            //Console.WriteLine("QUITO TEMPERAS");
            //Console.WriteLine((string)paleta);
            //Pausa();
            //tempera3 += 10;

            Console.WriteLine("agregar colores a la paleta");
            //for(; ; )
            //{
            //    Console.Clear();
            //    Console.WriteLine((string)paleta);
            //    paleta -= tempera3;
            //    Pausa();
            //}

        }

        static void Pausa()
        {
            Console.WriteLine("Presione enter para continuar. . .");
            while (Console.ReadKey().KeyChar != 13) ;
        }
    }
}
