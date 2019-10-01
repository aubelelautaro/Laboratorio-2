using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> ts = new Stack<int>();
            Random random = new Random();

            Console.WriteLine("PILA");
            
            for(int i = 1; i <= 20; i++)
            {
                ts.Push(random.Next(-100, 101));
            }

            siguiente();
            Console.WriteLine("Muestro la pila");
           
            //Console.WriteLine("//////////////////////////////////");
            //Console.WriteLine(ts.Peek());
            //Console.WriteLine("//////////////////////////////////");

            foreach (int value in ts)
            {
                Console.WriteLine(value.ToString());
            }

           
            int[] enteros = ts.ToArray();
            int aux;
            siguiente();
            Console.WriteLine("ORDENAR NUMEROS POSITIVOS DECRECIENTE (PILA)");

            for (int i = 0; i < enteros.Length - 1; i++)
            {
                for (int j = i + 1; j < enteros.Length; j++)
                {
                    if (enteros[i] < enteros[j])
                    {
                        aux = enteros[i];
                        enteros[i] = enteros[j];
                        enteros[j] = aux;
                    }
                }
            }

            for (int i = 0; i < enteros.Length; i++)
            {
                if (enteros[i] > 0)
                {
                    Console.WriteLine(enteros[i]);
                }
            }

            siguiente();
            Console.WriteLine("ORDENAR NUMEROS NEGATIVOS CRECIENTE (PILA)");
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
            siguiente();
            Console.WriteLine("COLAS");
            Queue<int> vs = new Queue<int>();
            for(int i = 0; i < 20; i++)
            {
                vs.Enqueue(random.Next(-100, 101));
            }
            siguiente();
            Console.WriteLine("MUESTRO LA COLA");
            Console.WriteLine(string.Join("\n", vs));
            siguiente();
            Console.WriteLine("MUESTRO LOS NUMEROS POSITIVOS DECRECIENTE (COLA)");
            enteros = null;
            enteros = vs.ToArray();
            for (int i = 0; i < enteros.Length - 1; i++)
            {
                for (int j = i + 1; j < enteros.Length; j++)
                {
                    if (enteros[i] < enteros[j])
                    {
                        aux = enteros[i];
                        enteros[i] = enteros[j];
                        enteros[j] = aux;
                    }
                }
            }
            for (int i = 0; i < enteros.Length; i++)
            {
                if (enteros[i] > 0)
                {
                    Console.WriteLine(enteros[i]);
                }
            }
            siguiente();
            Console.WriteLine("MUESTRO NUMEROS NEGATIVOS CRECIENTE (COLA)");
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
            siguiente();
            Console.WriteLine("Listas");

            List<int> vs1 = new List<int>();
            
            for(int i = 0; i < 20; i++)
            {
                vs1.Add(random.Next(-100, 101));
            }
            siguiente();
            Console.WriteLine("MUESTRO LA LISTA");
            Console.WriteLine(string.Join("\n", vs1));
            siguiente();
            Console.WriteLine("MUESTRO NUMEROS POSITIVOS DECRECIENTE (LISTA)");
            vs1.Sort(desc);
            foreach (int value in vs1)
                if(value > 0)
                Console.WriteLine(value);

            siguiente();
            Console.WriteLine("MUESTRO NUMEROS NEGATIVOS CRECIENTE (LISTA)");
            vs1.Sort(asc);
            foreach (int value in vs1)
                if (value < 0)
                    Console.WriteLine(value);

            siguiente();
            Console.WriteLine("fin del programa");
            Console.ReadKey();
        }

        static int desc(int p, int s)
        {
            if(p < s)
            {
                return 1;
            }
            else if(p == s)
            {
                return 0;

            }
            else
            {
                return -1;
            }
        }

        static int asc(int p, int s)
        {
            return -1* desc(p, s);
        }

        static void siguiente()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}
