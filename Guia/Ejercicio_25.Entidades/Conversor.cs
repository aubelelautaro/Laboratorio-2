using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_25.Entidades
{
    public class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            numero = Math.Truncate(Math.Abs(numero));

            return Convert.ToString((int)numero, 2);
        }

        public static string BinarioDecimal(string binario)
        {
            double numeroDecimal = 0;

            for (int i = 1; i <= binario.Length; i++)
            {
                switch (binario[i - 1])
                {
                    case '1':
                        numeroDecimal += Math.Pow(2, binario.Length - i);
                        break;

                    case '0':
                        numeroDecimal += 0;
                        break;

                    default:
                        return "Valor Invalido";
                }
            }
            return Convert.ToString(numeroDecimal);
        }
    }
}
