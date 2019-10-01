using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo e = new Equipo(5, "Celtics");
            Jugador uno = new Jugador(1212313, "pablo", 23, 2);
            Jugador dos = new Jugador(2132312, "nestor", 503, 123);
            Jugador tres = new Jugador(232121, "juana", 56, 15);
            Jugador cuatro = new Jugador(12121, "carlos",56,44);
            Jugador cinco = new Jugador(010101, "diana");
            Jugador seis = new Jugador(32344, "ernesto");

            if (e + uno)
                Console.WriteLine($"SE AGREGO JUGADOR: \n{uno.MostrarDatos()}");
            
            if(e + dos)
                Console.WriteLine($"SE AGREGO JUGADOR: \n{dos.MostrarDatos()}");

            if(e + tres)
                Console.WriteLine($"SE AGREGO JUGADOR: \n{tres.MostrarDatos()}");

            if(e + cuatro)
                Console.WriteLine($"SE AGREGO JUGADOR: \n{cuatro.MostrarDatos()}");

            if(e + cinco)
                Console.WriteLine($"SE AGREGO JUGADOR: \n{cinco.MostrarDatos()}");

            // no deberia agregar
            if(e+ seis)
                Console.WriteLine($"SE AGREGO JUGADOR: \n{seis.MostrarDatos()}");



            Console.ReadLine();

        }
    }
}
