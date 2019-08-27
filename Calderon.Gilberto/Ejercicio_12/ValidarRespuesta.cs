using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        /// <summary>
        /// Metodo que valida si una respuesta tomada del usuario 
        /// </summary>
        /// <param name="c"></param>
        /// <returns>Retorna true si la respuesta es 'S' sino retorna false</returns>
        public static bool ValidarS_N(char c)
        {
            bool ret = false;

            if(c == 'S' || c == 's')
            {
                ret = true;
            }

            return ret;
        }
    }
}
