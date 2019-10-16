using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /********* ARCHIBVOS DE TEXTO ***************/

            // parametro true es para agregar contenido sino lo sobreescribira

            StringBuilder incidencias = new StringBuilder();

            try
            {
                 MetodoUno();

            }
            catch(Exception e)
            {
                Console.WriteLine("en el main: " + e.Message);
                Console.WriteLine("En el main: " + e.InnerException.Message);
                Console.WriteLine(".StackTrace :" + e.StackTrace);
                incidencias.Append( e.StackTrace);
                // stacktrace devuelve un string del camino que produjo esa excepcion

               // .InnerExcepcion me devuelve un objeto del tipo excepcion anterior, que me produjo la excepcion actual
            }
            //AppDomain.CurrentDomain.BaseDirectory retorna el path absoluto del ejecutable 
            StreamWriter sw;
            try
            {
                sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "\\miArchivo.txt");

                sw.Write(incidencias);
                sw.WriteLine(DateTime.Now);
                sw.Close();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Presione cualquier tecla para continuar. . .");
            }


            // lee todo el contenido ReadToEnd
            //     Console.WriteLine(sr.ReadToEnd());
            /// readLine lee una linea desde el primer caracter del archivo hasta un salto de linea o el final del archivo
            //StreamReader sr;
            //using (sr = new StreamReader("C:\\miCarpeta\\miArchivo.txt"))
            //{
            //    string aux;
            //    int i = 1;

            //    while ((aux = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine("Linea: {0} " + aux, i);
            //        i++;
            //    }
            //}

            //sr.Close();
            Console.ReadKey();
        }

        public static void MetodoUno()
        {
            try
            {
                MetodoDos();
            }
            catch (Exception e)
            {
                Console.WriteLine("capturo excepcion en el metodo1 "+e.Message);
                throw new Exception("Exepcion en metodo1", e);
            }

        }

        public static void MetodoDos()
        {
            try
            {
                MetodoTres();
            }
            catch(Exception e)
            {
                Console.WriteLine("Capturado en el metodo dos: " + e.Message);
                throw new Exception(" excepcion en metodo2: ", e);
            }
        }

        public static void MetodoTres()
        {
            try
            {
                MetodoCuarto();
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Capturada en el metodo 3: "+ e.Message);
            }
        }

        public static void MetodoCuarto()
        {
            throw new MetodoCuatroException("Excepcion en metodo4");
        }
    }
}
