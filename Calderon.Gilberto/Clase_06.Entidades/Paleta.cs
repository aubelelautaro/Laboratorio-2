using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
    public class Paleta
    {
        private Tempera[] colores;
        private int cantidadMaximaColores;

        private Paleta():this(5)
        {
        }

        private Paleta(int cantidad)
        {
            this.cantidadMaximaColores = cantidad;
            this.colores = new Tempera[cantidad];
        }

        public static implicit operator Paleta(int cantidad)
        {
            if(cantidad > 0)
            {
                Paleta obj = new Paleta(cantidad);
                return obj;
            }
            else
            {
                return null;
            }
        }

        private string Mostrar()
        {
            string cadena = string.Format($"Cantidad Maxima de colores: {this.cantidadMaximaColores}\n\n");

            foreach(Tempera tempe in this.colores)
            {
                cadena += tempe;
            }

            return cadena;
        }

        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            if (!Object.Equals(paleta, null) && !Object.Equals(tempera, null))
            {
               foreach(Tempera tempe in paleta.colores)
                {
                    if(tempe == tempera)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }

        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            if (paleta != tempera)
            {
                paleta.colores[paleta.MostrarLugarLibre()] = tempera;
                return paleta;
            }
            else
            {
                for (int i = 0; i < paleta.colores.Length; i++)
                {
                    if (paleta.colores[i] == tempera)
                    {
                        paleta.colores[i] = paleta.colores[i] + 1;
                        return paleta;
                    }
                }
                return paleta;
            }
        }

        private int MostrarLugarLibre()
        {
            for (int i = 0; i < this.colores.Length; i++)
            {
                if (!Object.Equals(this.colores[i], null))
                {
                    return i;
                }
            }
            return -1;
        }

        public static int operator |(Paleta paleta, Tempera tempera)
        {
            if(paleta == tempera)
            {
                for(int i = 0; i < paleta.colores.Length; i++)
                {
                    if (paleta.colores[i] == tempera)
                        return i;
                }
            }
            return -1;
        }

    }
 }
