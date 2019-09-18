using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_02.Entidades;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // version del framework 4.6.1
            Console.WriteLine("Hello World!");

            MiClase.edad = 23;
            MiClase.nombre = "Juan";
            MiClase.MostrarEdad();
            string nom = MiClase.RetornarNombre();
            Console.WriteLine(nom);

            MiLibreria.MiClase.nombre = "Gilberto";
            Console.WriteLine(MiLibreria.MiClase.MostrarNombre());

            // Console.Clear();

            Sello.mensaje = "Hola Mundo"; // Clase02.Entidades
            string mensaje = Sello.Imprimir();

            Sello.mensaje = "Hola";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();

            Console.Write("Escriba lo que sea: ");
            Sello.mensaje = Console.ReadLine();
            //    Sello.ImprimirEnColor();
            Console.Clear();
            Sello.Imprimir();

            //string[] n = { "ana", "pedro", "agus", "jorge", "mariono" };

            //for (int i = 0; i < n.Length; i++)
            //{
            //    if (string.Compare())
            //}
            Console.WriteLine(string.Compare("a", "z"));

            

            Console.ReadKey();
        }
    }
}
