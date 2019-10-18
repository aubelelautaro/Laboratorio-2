using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private string documento;
        private string apellido;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }

            set
            {
                if (ValidarDocumentacion(value))
                {
                   this.documento = value;
                }
                else
                {
                    this.documento = "";
                }
            }
        }
        #endregion

        #region Constructores
        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }
        #endregion

        #region Metodos
        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: "+this.nombre);
            sb.AppendLine("Apellido: "+this.apellido);
            sb.AppendLine("Documento: "+this.documento);
            return sb.ToString();
        }

        protected abstract bool ValidarDocumentacion(string doc);
        #endregion



    }
}
