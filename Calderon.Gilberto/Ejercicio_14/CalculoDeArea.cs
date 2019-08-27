using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        /// <summary>
        /// Recibe la base de un cuadrado para luego calcular su area.
        /// </summary>
        /// <param name="num1"></param>
        /// <returns>Retorna el area del cuadrado.</returns>
        public static double CalcularCuadrado(double num1)
        {
            return num1 * num1;
        }

        /// <summary>
        /// Recibe la base y altura de un triangulo para luego calcular su area.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Retorna el area de un triangulo.</returns>
        public static double CalcularTriangulo(double num1, double num2)
        {
            return ((1 / 2) * num1 * num2);
        }

        /// <summary>
        /// Recibe el radio de un circulo Y calcula su area.
        /// </summary>
        /// <param name="num1"></param>
        /// <returns>Retorna el area de un circulo.</returns>
        public static double CalcularCirculo(double num1)
        {
            return (Math.PI * (num1 * num1));
        }
    }
}
