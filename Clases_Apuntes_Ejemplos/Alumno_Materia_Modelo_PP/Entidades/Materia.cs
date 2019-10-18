using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        #region Atributos
        private List<Alumno> _alumnos;
        private EMateria _nombre;
        private static Random _notaParaAlumno;
        #endregion

        #region Propiedades
        private Materia()
        {
            this._alumnos = new List<Alumno>();
        }

        private Materia(EMateria nombre) : this()
        {
            this._nombre = nombre;
        }

        static Materia()
        {
            Materia._notaParaAlumno = new Random();
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Materia: {this._nombre}");
            sb.AppendLine($"**************************************");
            sb.AppendLine($"***************ALUMNOS****************");
            foreach (Alumno value in this._alumnos)
            {
                sb.AppendLine(Alumno.Mostrar(value));
            }
            return sb.ToString();
        }

        public void CalificarAlumnos()
        {
            foreach (Alumno value in this._alumnos)
            {
                value.Nota = Materia._notaParaAlumno.Next(0, 11);
            }
        }
        #endregion

        #region Sobrecargas de Operadores
        public static implicit operator Materia(EMateria nombre)
        {
            return new Materia(nombre);
        }

        public static implicit operator float(Materia m)
        {
            float total = 0;
            foreach (Alumno value in m._alumnos)
            {
                total += value.Nota;
            }

            return total / m._alumnos.Count;
        }

        public static explicit operator string(Materia materia)
        {
            return materia.Mostrar();
        }

        public static bool operator ==(Materia m, Alumno a)
        {
            if (!Object.ReferenceEquals(m, null) && !Object.ReferenceEquals(a, null))
            {
                foreach (Alumno value in m._alumnos)
                {
                    if (value == a)
                        return true;
                }
            }

            return false;
        }

        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }

        public static Materia operator +(Materia m, Alumno a)
        {
            if (m != a)
            {
                m._alumnos.Add(a);
                Console.WriteLine($"Se agrego el alumno a la materia {m._nombre}!!!");
            }
            else
            {
                Console.WriteLine($"El alumno ya esta en la materia de {m._nombre}!!!");
            }
            return m;
        }

        public static Materia operator -(Materia m, Alumno a)
        {
            if (m == a)
            {
                m._alumnos.Remove(a);
                Console.WriteLine($"Se quito el alumno en la materia de {m._nombre}!!!");
            }
            else
            {
                Console.WriteLine($"El alumno no esta en la materia de {m._nombre}!!!");
            }
            return m;
        }
        #endregion
    }
}
