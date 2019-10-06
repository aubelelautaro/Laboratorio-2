using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        #region Atributos
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;
        #endregion

        #region Propiedades
        public string AnioDivision
        {
            get
            {
                return string.Format("{0}°{1}", this.anio, this.division.ToString());
            }
        }
        #endregion

        #region Constructores
        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division,Profesor profesor):this()
        {
            this.anio = anio;
            this.profesor = profesor;
            this.division = division;
        }
        #endregion

        #region Sobrecarga de Operadores
        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CURSO: {c.AnioDivision}");
            sb.AppendLine($"PROFESOR: {c.profesor.ExponerDatos()}");
            sb.AppendLine("ALUMNOS: ");
            foreach(Alumno alumno in c.alumnos)
            {
                sb.AppendLine(alumno.ExponerDatos());
            }
            return sb.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            return string.Compare(c.AnioDivision, a.AnioDivision) == 0;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if(c == a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }
        #endregion
    }
}
