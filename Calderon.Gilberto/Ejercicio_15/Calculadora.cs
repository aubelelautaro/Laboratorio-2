using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio_15
{
    class Calculadora
    {
        /// <summary>
        /// Recibe dos numeros para luego ser calculados segun lo que se pase por parametro.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operacion"></param>
        /// <returns>Retorna el resultado de la operacion.</returns>
        public static double Calcular(double numero1, double numero2, char operacion)
        {
       
            switch (operacion)
            {
                case (char)43:
                    return numero1 + numero2;

                case (char)45:
                    return numero1 - numero2;

                case (char)42:
                    return numero1 * numero2;

                case (char)47:

                    if(Validar(numero2))
                    {
                        return numero1 / numero2;
                    }
                    else
                    {
                        return 0;
                    }
                    
                default:
                    return 0;
                 
            }
            
        }

        private static bool Validar(double num)
        {
            if(num != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
