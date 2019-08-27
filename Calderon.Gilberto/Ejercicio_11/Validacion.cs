using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {

        /// <summary>
        ///     Valida un numero dentro de un rango.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Retorna un valor de tipo booleano, si el numero no esta dentro del rango establecido
        /// retorna false sino retorna true</returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool valido = true;

            if(valor < min || valor > max)
            {
                valido = false;
            }

            return valido;
        }
    }
}
