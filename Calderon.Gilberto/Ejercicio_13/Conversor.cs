using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {

        public static string DecimalBinario(double num)
        {
            string binario = string.Empty;

            for (; num > 0;)
            {
                binario += ((int)(num % 2)).ToString();
                num /= 2;
            }

            return ReverseString(binario);
        }

        public static double BinarioDecimal(string num)
        {
            double nroDecimal = Convert.ToDouble(num);

            return nroDecimal;
        }

        /// <summary>
        /// Invierte una cadena de caracteres.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Retorna una cadena de caracteres de forma invertida</returns>
        private static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
