using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor:Persona
    {
        #region
        private DateTime fechaIngreso;
        #endregion

        #region Constructores
        public Profesor(string nombre ,string apellido, string documento):base(nombre,apellido, documento)
        {

        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
        #endregion

        #region Propiedades
        public int Antiguedad
        {
            get
            {
                return (DateTime.Now-this.fechaIngreso).Days;
            }
        }
        #endregion

        #region Metodos
        protected override bool ValidarDocumentacion(string doc)
        {
            return doc.Length == 8;
        }

        public override string ExponerDatos()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PROFESOR:");
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine("Fecha de ingreso: " + this.fechaIngreso);
            sb.AppendLine("Antiguedad: " + this.Antiguedad+ " Dias");
            sb.AppendLine("-----------------------------");
            return sb.ToString();
        }
        #endregion
    }
}
