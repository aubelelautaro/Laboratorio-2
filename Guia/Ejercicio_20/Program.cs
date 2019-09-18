
#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Billetes;

#endregion

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro e = new Euro(10, 0.90f);
            Dolar d = new Dolar(10);
            Pesos p = new Pesos(10, 55f);

            Euro aux_e = e + d;
            Console.WriteLine("Euro + Dólar: {0}", aux_e.GetCantidad());
            aux_e = e + p;
            Console.WriteLine("Euro + Pesos: {0}", aux_e.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Dolar aux_d = d + e;
            Console.WriteLine("Dólar + Euro: {0}", aux_d.GetCantidad());
            aux_d = d + p;
            Console.WriteLine("Dólar + Pesos: {0}", aux_d.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Pesos aux_p = p + e;
            Console.WriteLine("Pesos + Euro: {0}", aux_p.GetCantidad());
            aux_p = p + d;
            Console.WriteLine("Pesos + Dólar: {0}", aux_p.GetCantidad());

            Console.ReadKey();
        }
    }
}
