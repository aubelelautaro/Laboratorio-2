using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program p = new Program();
                p.MetodoCuatro();
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            finally
            {
                Console.WriteLine("Pulse cualquier tecla para continuar. . .");
            }
            Console.ReadLine();
        }
        

        static void MetodoUno()
        {
           throw new DivideByZeroException();
        }

        static void MetodoDos()
        {
            try
            {
                MetodoUno();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        
        static void MetodoTres()
        {
            try
            {
                MetodoDos();
            }
            catch(Exception e)
            {
                throw new UnaExcepcion(e.InnerException.Message, e.InnerException);
            }
        }

        void MetodoCuatro()
        {
            try
            {
                MetodoTres();
            }
            catch(Exception e)
            {
                throw new MiExcepcions($"Excepcion MiExcepcions: {e.Message} {e.InnerException.Message}", e);
            }
        }
    }
}
