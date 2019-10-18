using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        #region Atributos
        protected string nombre;
        protected string apellido;
        protected int legajo;
        protected ETipoExamen examen;
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

        #endregion

        #region Enumerados
        public enum ETipoExamen
        {
            Primero,
            Segundo,
            Final
        }
        #endregion

        #region Constructor
        public Alumno(string nombre, string apellido, int legajo, ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }

        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Alumno a, Alumno b)
        {
            bool retorno = false;
            if(!Object.ReferenceEquals(a,null) && !Object.ReferenceEquals(b, null))
            {
                if(a.legajo == b.legajo)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Alumno a, Alumno b)
        {
            return !(a == b);
        }

        #endregion

        #region metodos
        public override string ToString()
        {
            return Alumno.Mostrar(this);
        }

        public static string Mostrar(Alumno a)
        {
            return !Object.Equals(a, null) ? $"nombre: {a.nombre}, apellido: {a.apellido}, legajo: {a.legajo}, Examen: {a.examen}" : "No existe el alumno";
        }

        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            int retorno = 0;

            if (a.legajo > b.legajo)
            {
                retorno = 1;
            }
            else 
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int OrdenarPorLegajoDesc(Alumno a, Alumno b)
        {
            return -1 * Alumno.OrdenarPorApellidoAsc(a,b);
        }

        public static int OrdenarPorApellidoAsc(Alumno a, Alumno b)
        {
            int retorno = 0;

            // a.apellido.CompareTo(b.apellido);
            if(string.Compare(a.apellido, b.apellido) < 0)
            {
                retorno = 1;
            }
            else
            {
                retorno = -1;
            }
            return retorno;
        }

        public static int OrdenarPorApellidoDesc(Alumno a, Alumno b)
        {
            return -1 * Alumno.OrdenarPorApellidoAsc(a, b);
        }
        #endregion
    }
}
