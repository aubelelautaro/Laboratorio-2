using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnidadesDeTemperatura;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c = 10;
            Kelvin k = (Kelvin)c;
            Fahrenheit f= (Fahrenheit)c;

            Fahrenheit f2 = 90;
            Celsius c2 = (Celsius)f2;
            Kelvin k2 = (Kelvin)f2;

            Kelvin k3 = 400;
            Celsius c3 = (Celsius)k3;
            Fahrenheit f3 = (Fahrenheit)k3;

            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine($"{c.GetTemperatura()} Celsius a Kelvin: {k.GetTemperatura()}");
            Console.WriteLine($"{c.GetTemperatura()} Celsius a Fahrenheit: {f.GetTemperatura()}");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine($"{k3.GetTemperatura()} Kelvin a Celsius: {c3.GetTemperatura()}");
            Console.WriteLine($"{k3.GetTemperatura()} Kelvin a Fahrenheit: {f3.GetTemperatura()}");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine($"{f2.GetTemperatura()} Fahrenheit a Kelvin: {k2.GetTemperatura()}");
            Console.WriteLine($"{f2.GetTemperatura()} Fahrenheit a Celsius: {c2.GetTemperatura()}");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.ReadKey(true);
        }
    }
}
