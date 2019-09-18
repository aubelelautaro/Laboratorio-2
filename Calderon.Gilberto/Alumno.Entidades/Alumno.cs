using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno.Entidades
{
    public class Alumno
    {
        protected string nombre;
        protected string apellido;
        protected int legajo;
        protected ETipoExamen examen;

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

        public int Legajo
        {
            get
            {
                return this.legajo;
            }
        }

        public ETipoExamen Examen
        {
            get
            {
                return this.examen;
            }
        }

        public enum ETipoExamen
        {
            Primero,
            Segundo,
            Final
        }

        public Alumno(string nombre, string apellido, int legajo, ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }

        public static string Mostrar(Alumno a)
        {
            return !Object.Equals(a, null) ? $"nombre: {a.nombre}, apellido: {a.apellido}, legajo: {a.legajo}, Examen: {a.examen}" : "No existe el alumno";
        }

        public static bool operator ==(Alumno a, Alumno b)
        {
            return (a.legajo == b.legajo);
        }

        public static bool operator !=(Alumno a, Alumno b)
        {
            return !(a == b);
        }

        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            int retorno = 0;

            // 1 si se cumple el criterio

            if (a.legajo > b.legajo)
            {
                retorno = 1;
            }
            else if (a.legajo < b.legajo)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int OrdenarPorLegajoDesc(Alumno a, Alumno b)
        {
            int retorno = 0;

            // 1 si se cumple el criterio
            if (a.legajo < b.legajo)
            {
                retorno = 1;
            }
            else if (a.legajo > b.legajo)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int OrdenarPorApellidoAsc(Alumno a, Alumno b)
        {
            return string.Compare(a.apellido, a.apellido);
        }

        public static int OrdenarPorApellidoDesc(Alumno a, Alumno b)
        {
            return -1 * Alumno.OrdenarPorApellidoAsc(a, b);
        }

      

    }
}
