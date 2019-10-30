using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization; // debe estar incluida para serializar 
using System.Xml;
using System.IO;

namespace Entidades
{
    [XmlInclude(typeof(Persona))]

    public class Persona:IXML
    {
        public string nombre;
        public string apellido;
        private int edad;
        private List<string> apodos;

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public List<string> Apodos
        {
            get
            {
                return this.apodos;
            }
        }

        public Persona(string nombre, string apellido, int edad):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;            
        }

        public Persona() {
            this.apodos = new List<string>();
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre}, Apellido: {this.apellido}";
        }

        public bool Guardar(string str)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                using(XmlTextWriter xmlTextWriter = new XmlTextWriter(str, Encoding.UTF8))
                {
                    xmlSerializer.Serialize(xmlTextWriter, this);
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool Leer(string str, out object obj)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                using (XmlTextReader xmlTextReader = new XmlTextReader(str))
                {
                    obj = (Persona)xmlSerializer.Deserialize(xmlTextReader);
                }
            }
            catch 
            {
                obj = null;
                return false;
            }

            return true;
        }
    }
}
