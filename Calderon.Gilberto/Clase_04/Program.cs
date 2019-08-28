
#region Directivas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

#region MisClases
using Clase_04.Entidades;
#endregion

namespace Clase_04
{
    class Program
    {
        /// <summary>
        /// Inicio del programa.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Cosa cosaUno = new Cosa();
            Cosa c = new Cosa();

            //cosaUno.EstablecerValor("HOLA");
            //cosaUno.EstablecerValor(DateTime.Now);
            //cosaUno.EstablecerValor(100);
            //Console.WriteLine(cosaUno.Mostrar());

            Cosa c1 = new Cosa();
            Cosa c2 = new Cosa("C2");
            Cosa c3 = new Cosa("C3", DateTime.Now);
            Cosa c4 = new Cosa("C4", new DateTime(1987, 11, 12), 1230);

            Console.WriteLine(c1.Mostrar() + c2.Mostrar() + c3.Mostrar() + c4.Mostrar());

            Console.ReadKey();
        
        }
    }
}
