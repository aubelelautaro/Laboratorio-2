using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization; // debe estar incluida para serializar 
using System.Xml;
using System.IO;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona obj = new Persona("Gilberto", "Calderon",18);
            //Console.WriteLine(obj);

            ///* SERIALIZAR */
            //try
            //{
            //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona)); // XmlSerializer: permite la serializacion y la deserializacion de un objeto
            //                                                                      // Lanza una excepcion ya que no tiene un constructor por default
            //                                                                      // Tambien lanza una excepcion si la clase que va a deserealizar no es publica

            //    using (XmlTextWriter xmlTextWriter = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\persona.xml", Encoding.UTF8))
            //    {
            //        // StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\persona.xml");
            //        xmlSerializer.Serialize(xmlTextWriter, obj);
            //        // streamWriter.Close(); se usa close si no uso el using
            //       // xmlTextWriter.Close(); se usa close si no uso el using

            //    // los atributos privados no se serializan
            //    // solo se serializan los atributos siempre y cuando sean publicos, no los metodos
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            ///*DESERIALIZAR*/
            //try
            //{
            //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
            //    using (XmlTextReader xmlTextReader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\persona.xml"))
            //    {
            //        // si el archivo no se puede acceder muestra una excepcion, el path debe existir
            //        obj = (Persona)xmlSerializer.Deserialize(xmlTextReader);
            //    }
            //    Console.WriteLine("Despues de deserealizar: ");
            //    Console.WriteLine(obj);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //List<Persona> lista = new List<Persona>();
            //Persona per1 = new Persona("Carlos", "Rodriguez", 21);
            //Persona per2 = new Persona("Ana", "Martinez", 23);
            //Persona per3 = new Persona("Gilberto", "Calderon", 18);

            //per1.Apodos.Add("carlitos");
            //per2.Apodos.Add("anita");
            //per3.Apodos.Add("gilbert");

            //lista.Add(per1);
            //lista.Add(per2);
            //lista.Add(per3);

            //try
            //{
            //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Persona>));
            //    using (XmlTextWriter xmlTextWriter = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\lista.xml", Encoding.UTF8))
            //    {
            //        xmlSerializer.Serialize(xmlTextWriter, lista);
            //    }
            //    // Solo se va a poder serializar atributos privados, si tienen propiedades de lectura/ecritura

            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            List<Persona> lista = new List<Persona>();
            Persona per1 = new Persona("Carlos", "Rodriguez", 21);
            Persona per2 = new Persona("Ana", "Martinez", 23);
            Persona per3 = new Persona("Gilberto", "Calderon", 18);

            per1.Apodos.Add("carlitos");
            per2.Apodos.Add("anita");
            per3.Apodos.Add("gilbert");

            lista.Add(per1);
            lista.Add(per2);
            lista.Add(per3);
            Persona per4 = new Persona("Gilberto", "Calderon", 18);
            Empleado emp1 = new Empleado("Pedro", "Perez", 21, 1234, 21000);
            Alumno alum1 = new Alumno("Pepito", "Perez", 23, 7);

            lista.Add(per1);
            lista.Add(emp1);
            lista.Add(alum1);

            //foreach(Persona value in lista)
            //{
            //    if(Serializadora.Serializar(value))
            //        Console.WriteLine("Elemento serializado");
            //    else
            //        Console.WriteLine("Elemento no serializado");

            //}

            // serializar  y deserializar la lista
            Console.ReadKey();
        }
    }
}
