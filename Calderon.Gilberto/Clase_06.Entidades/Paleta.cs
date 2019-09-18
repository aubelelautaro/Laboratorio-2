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

        //public Tempera[] Colores
        //{
        //    get
        //    {
        //        return this.colores;
        //    }
        //}

        //public Tempera[] GetColores()
        //{
        //    return this.colores;
        //}

            /** INDEXADOR **/
        public Tempera this[int index]
        {
            get
            {
                return this.colores[index];
            }

            set
            {
                this.colores[index] = value;
            }
        }

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
            return cantidad > 0 ? new Paleta(cantidad) : null; // ahorra lineas de codigo
        }

        private string Mostrar()
        {
            int indice = 1;
            string cadena = string.Format($"Cantidad Maxima de colores: {this.cantidadMaximaColores}\n\n");

            foreach(Tempera tempe in this.colores)
            {
                cadena += string.Format($"{indice}- {(string)tempe}");
                cadena += "\n";
                indice++;
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
                if(paleta.MostrarLugarLibre() != -1)
                {
                    paleta.colores[paleta.MostrarLugarLibre()] = tempera;
                }
                    
            }
            else
            {
                if(paleta.colores[paleta | tempera].Cantidad <= 0)
                {
                    paleta.colores[paleta | tempera] = null;

                }
                else
                {
                    paleta.colores[paleta | tempera] += tempera.Cantidad;
                }
            }

            return paleta;
        }

        private int MostrarLugarLibre()
        {
            for (int i = 0; i < this.colores.Length; i++)
            {
                if (Object.Equals(this.colores[i], null))
                {
                    return i;
                }
            }
            return -1;
        }

        public static int operator |(Paleta paleta, Tempera tempera)
        {
            Int16 indice = -1;

            if(paleta == tempera)
            {
                for(indice = 0; indice < paleta.colores.Length; indice++)
                {
                    if (paleta.colores[indice] == tempera)
                    {
                        return indice;

                    }
                }
            }
            return indice;
        }
        //*************///
        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {
            int indice = paleta | tempera;
            if (tempera.Cantidad > 0)
            {
                if (paleta == tempera)
                {
                    paleta.colores[indice] += -1;
                
                }

            }
            
               
            return paleta;
        }

    }
 }
