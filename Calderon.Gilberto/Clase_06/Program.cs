﻿#region Using Directives
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
            //Tempera obj = new Tempera(ConsoleColor.Black, "marca", 12);
            //Tempera obj2 = new Tempera(ConsoleColor.Black, "marca", int.MaxValue);
            //Console.WriteLine(obj == obj2); // true
            //Console.WriteLine((string)obj); // black -- marca -- 12

            Paleta a ;
            //Paleta b = new Paleta(55);

            a = 3;
            Console.WriteLine((string)a);
            Console.ReadKey(true);
        }
    }
}