using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class Capitulo
    {
        #region Atributos
        private int numero;
        private string titulo;
        private int paginas;
        private static Random generadorDeNumeros;
        private static Random generadorDePaginas;

        #endregion

        #region Propiedades
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public string Titulo
        {
            get
            {
                return this.titulo;
            }
        }

        public int Paginas
        {
            get
            {
                return this.paginas;
            }
        }
        #endregion

        #region Constructores
        static Capitulo()
        {
            Capitulo.generadorDeNumeros= new Random();
            Capitulo.generadorDePaginas = new Random();

        }

        private Capitulo(int numero, string titulo, int paginas)
        {
            this.numero = numero;
            this.titulo = titulo;
            this.paginas = paginas;
        }

        #endregion

        #region operadores
        public static implicit operator Capitulo(string cadena)
        {
            return new Capitulo(Capitulo.generadorDeNumeros.Next(1, 16), cadena, Capitulo.generadorDePaginas.Next(15,234));
        }

        public static bool operator ==(Capitulo c1, Capitulo c2)
        {
            bool iguales = false;

            if(!Object.Equals(c1,null) && !Object.Equals(c2, null))
            {
                if(c1.numero == c2.numero && c1.titulo == c2.titulo)
                {
                    iguales = true;
                }
            }

            return iguales;
        }

        public static bool operator !=(Capitulo c1, Capitulo c2)
        {
            return !(c1 == c2);
        }
        #endregion
    }
}
