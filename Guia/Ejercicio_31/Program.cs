using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] vs = new bool[3] ;

            vs[0] = false;
            vs[1] = true;
            vs[2] = false;

            Console.WriteLine(vs[0].GetHashCode()+ " " + vs.GetHashCode());
            
            Console.ReadLine();
        }
    }
}
