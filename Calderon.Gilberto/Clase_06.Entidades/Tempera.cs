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

        public string Marca
        {
            get
            {
                return this.marca;
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
        } 

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
            return string.Format($"Marca: {this.marca}, Color: {this.color}, Cantidad: {this.cantidad}\n");
        }

        public static implicit operator string(Tempera tempera)
        {
            return !Object.Equals(tempera, null) ? tempera.Mostrar() : "No hay tempera";
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
            if (!Object.Equals(tempera, null))
            {
                if (tempera.cantidad <= 0)
                {
                    tempera = null;
                }
                else
                {
                    tempera.cantidad = tempera.cantidad + num;
                }

            }
            return tempera;
            
        }

        public static Tempera operator +(Tempera tempera1, Tempera tempera2)
        {
            return (tempera1 == tempera2) ? tempera1 + tempera2.cantidad : tempera1; /**    */
        }
    }
}
