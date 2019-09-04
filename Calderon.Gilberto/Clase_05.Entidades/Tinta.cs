using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color):this()
        {
            this._color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipoTinta):this(color)
        {
            this._tipo = tipoTinta;
        }

        private  string Mostrar()
        {
            return $"Color: {this._color} Tipo de tinta: {this._tipo}";
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        public static bool operator ==(Tinta tinta1, Tinta tinta2)
        { // verificar con object si son nulas, ya que al sobrecargar el operador solo va a comparar sus atributos, no la referencia de ambos objetos en el heap
          
            if(!Object.Equals(tinta1, null) && !Object.Equals(tinta2, null))
            {
                if (tinta1._color == tinta2._color && tinta1._tipo == tinta2._tipo)
                {
                    return true;
                }
            }

            return false;
           
        }

        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }

        public static bool operator ==(Tinta tinta, ConsoleColor color)
        {
            if (!Object.Equals(tinta, null))
            {
                if (tinta._color == color)
                {
                    return true;
                }
            }
           
            return false;
        }

        public static bool operator !=(Tinta tinta, ConsoleColor color)
        {
            return !(tinta._color == color);
        }

        public static explicit operator string(Tinta tinta)
        {
            if (!Object.Equals(tinta, null))
                return tinta.Mostrar();
            else
                return string.Empty;
        }
    }
}
