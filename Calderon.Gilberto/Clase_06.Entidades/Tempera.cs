using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.cantidad = cantidad;
            this.color = color;
            this.marca = marca;
        }

        /// <summary>
        /// Muestra los atributos de la tempera.
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            return $"{this.marca} ---- {this.color} ---- {this.cantidad}\n";
        }

        public static implicit operator string(Tempera tempera)
        {
            if(!Object.Equals(tempera, null))
            {
                return tempera.Mostrar();

            }
            else
            {
                return "No hay tempera\n\n";
            }
        }

        public static bool operator ==(Tempera tempera, Tempera tempera2)
        {
            if(!Object.Equals(tempera, null) && !Object.Equals(tempera2, null))
            {
                if (tempera.marca == tempera2.marca && tempera.color == tempera2.color)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Tempera tempera, Tempera tempera2)
        {
            return !(tempera == tempera2);
        }

        public static Tempera operator +(Tempera tempera, int num)
        {
            if(!Object.Equals(tempera, null))
            {
                tempera.cantidad += num;
                return tempera;
            }
            else
            {
                return tempera;
            }
        }

        public static Tempera operator +(Tempera tempera1, Tempera tempera2)
        {
            if (tempera1 == tempera2)
            {
                return (tempera1 + tempera2.cantidad);
            }
            else
            {
                return tempera1;
            }
        }
    }
}
