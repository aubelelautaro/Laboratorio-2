using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_30.Entidades;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(15, 4);
            AutoF1 a1 = new AutoF1(15, "esc1");
            AutoF1 a2 = new AutoF1(30, "esc2");
            AutoF1 a3 = new AutoF1(10, "esc3");
            AutoF1 a4 = new AutoF1(10, "esc3");
            AutoF1 a5 = new AutoF1(21, "esc4");
            AutoF1 a6 = new AutoF1(23, "esc5");

            
            Console.WriteLine(competencia.MostrarDatos());
            Siguiente();


            if(competencia + a1)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se Agrego el Participante");
            }
            Siguiente();      
            if(competencia + a2)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se Agrego el Participante");
            }
            Siguiente();
            if(competencia + a3)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se Agrego el Participante");
            }
            Siguiente();
            if(competencia + a4)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se Agrego el Participante");
            }
            Siguiente();
            if(competencia + a5)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se Agrego el Participante");

            }
            Siguiente();
            if(competencia - a5)
            {
                Console.WriteLine("Quito el ultimo participante");
                Console.WriteLine(a5.MostrarDatos());
                Console.WriteLine(competencia.MostrarDatos());
            }
            Siguiente();
            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }

        private static void Siguiente()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}
