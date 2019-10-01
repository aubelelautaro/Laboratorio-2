using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] enteros = new int[20];
            int aux;
            Random r = new Random();

            for (int i = 0; i < enteros.GetLength(0); i++)
            {
                enteros[i] = r.Next(-101, 101);
            }

            Console.WriteLine("Muestro el contenido del array");
            Console.WriteLine(string.Join("\n", enteros));

            Console.WriteLine("//////////////////////////////////////////////////");

            Console.WriteLine("Muestro los numero del array positivos de forma decreciente\n");
            
            for(int i= 0; i < enteros.Length-1; i++)
            {
                for(int j = i+1; j < enteros.Length; j++)
                {
                    if (enteros[i] < enteros[j])
                    {
                        aux = enteros[i];
                        enteros[i] = enteros[j];
                        enteros[j] = aux;
                    }
                }
            }

            for(int i = 0; i < enteros.Length; i++)
            {
                if(enteros[i] > 0)
                {
                    Console.WriteLine(enteros[i]);
                }
            }


            Console.WriteLine("//////////////////////////////////////////////////");
                
            Console.WriteLine("Muestro los numeros del array de forma creciente");

            for (int i = 0; i < enteros.Length - 1; i++)
            {
                for (int j = i + 1; j < enteros.Length; j++)
                {
                    if (enteros[i] > enteros[j])
                    {
                        aux = enteros[i];
                        enteros[i] = enteros[j];
                        enteros[j] = aux;
                    }
                }
            }

            for (int i = 0; i < enteros.Length; i++)
            {
                if (enteros[i] < 0)
                {
                    Console.WriteLine(enteros[i]);
                }
            }
            Console.ReadKey(true);
        }
    }
}
