using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno: Persona
    {
        #region Atributos
        private short anio;
        private Divisiones division;
        #endregion

        #region Propiedades
        public string AnioDivision
        {
            get
            {
                return string.Format("{0}°{1}", anio,  division);
            }
        }
        #endregion

        #region Constructores
        public Alumno(string nombre, string apellido, string documento,short anio,Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }
        #endregion

        #region Metodos
        protected override bool ValidarDocumentacion(string doc)
        {
            int contadorGuion = 0;
            foreach(Char value in doc)
            {
                if(value != '-')
                {
                    if (!char.IsDigit(value))
                    {
                        return false;
                    }
                }
                else
                {
                    contadorGuion++;
                }
            }

            if(contadorGuion < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Alumno:");
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine("Division: "+this.AnioDivision);
            sb.AppendLine("-------------------");
            return sb.ToString();
        }
        #endregion
    }
}
