using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_17_Entidades;


namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_17";

            Boligrafo boligrafoUno = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoDos = new Boligrafo(ConsoleColor.Red, 50);
        }
    }
}
