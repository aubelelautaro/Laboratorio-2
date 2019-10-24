using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion avion = new Avion(120000, 300); // genero un avion
            Comercial aComercial = new Comercial(300000, 800, 70); // genero un avion comercial

            Console.Write("Precio de un avion: ");
            avion.MostrarPrecio();
            

            IAFIP afip = avion; // A una variable de tipo Interfaz se le puede asignar la instancia de un objeto que implemente esa interfaz
            IARBA arba = avion;

            Console.WriteLine("Impuesto Nacional del avion: {0}", Gestion.MostrarImpuestoNacional(afip));
            Console.WriteLine("Impuesto provincial del avion {0}", Gestion.MostrarImpuestoProvincial(arba));

            IARBA arbaComercial = aComercial;
            Console.WriteLine();

            Console.Write("Precio de un avion comercial: ");
            aComercial.MostrarPrecio();
            Console.WriteLine("Impuesto Provincial de un avion comercial {0}", Gestion.MostrarImpuestoProvincial(arbaComercial));

            
            Console.ReadLine();
        }
    }
}
