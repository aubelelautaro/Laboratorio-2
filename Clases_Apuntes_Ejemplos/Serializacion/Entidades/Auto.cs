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
    public class Auto:IXML
    {
        public string marca;
        public double precio;

        public Auto(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        public Auto() { }

        public override string ToString()
        {
            return $"Marca: {this.marca}, Precio: {this.precio}";
        }

        public bool Guardar(string str)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Auto));
                using (XmlTextWriter xmlTextWriter = new XmlTextWriter(str, Encoding.UTF8))
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
                using (XmlTextReader xmlTextReader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\persona.xml"))
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
