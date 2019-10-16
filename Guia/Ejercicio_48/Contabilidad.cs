using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Contabilidad<T,U> where T:  Documento where U: Documento, new()
    {
        #region Atributos
        private List<T> ingresos;
        private List<U> egresos;
        #endregion

        public Contabilidad()
        {
            this.egresos = new List<U>();
            this.ingresos = new List<T>();
        }

        #region Metodos
        public static Contabilidad<T,U> operator +(Contabilidad<T, U> c, T ingreso)
        {
         

                return c;
        }
        #endregion
    }
}
