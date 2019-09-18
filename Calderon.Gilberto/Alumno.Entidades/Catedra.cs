using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno.Entidades
{
    public class Catedra
    {
        private List<Alumno> alumnos;

        public List<Alumno> Alumnos
        {
            get
            {
                return this.Alumnos;
            }
        }

        public enum ETipoOrdenamiento
        {
            LegajoAscendente,
            LegajoDescendente,
            ApellidoAscendente,
            ApellidoDescendente
        }

        public static bool operator ==(Catedra c, Alumno a)
        {
            return (!Object.Equals(c, null) && !Object.Equals(a, null)) ? c.alumnos.Contains(a) : false;
        }


        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c == a);
        }

        public static bool operator +(Catedra c, Alumno a)
        {
            bool retorno = false;

            if (c != a)
            {
                retorno = true;
                c.alumnos.Add(a);
            }

            return retorno;
        }

        public static int operator |(Alumno a, Catedra c)
        {
            int indice = -1;

            if(c == a)
            {
               indice =  c.alumnos.IndexOf(a);
            }

            return indice;
        }

        public static bool operator -(Catedra c, Alumno a)
        {
            bool retorno = false;
            if(c == a)
            {
                retorno = c.alumnos.Remove(a);  
            }
            return retorno;
        }


    }
}
