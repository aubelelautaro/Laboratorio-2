using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class Libro
    {
        #region Atributos
        private string titulo;
        private string autor;
        private List<Capitulo> capitulos;
        #endregion

        #region Propiedades
        public int CantidadDePaginas
        {
            get
            {
                int cantidadTotal = 0;

                foreach(Capitulo value in this.capitulos)
                {
                    cantidadTotal += value.Paginas;
                }

                return cantidadTotal;
            }
        }

        public int CantidadDeCapitulos
        {
            get
            {
                return this.capitulos.Count;
            }
        }


        public Capitulo this[int i]
        {
            get
            {
                if(0 < i  && i > this.capitulos.Count)
                {
                    return null;
                }
                else
                {
                    return this.capitulos[i];
                }
            }
           
            set
            {
                if (i < 0 || i >= (this.capitulos.Count))
                {
                    this.capitulos.Add(value);
                }
                else
                {
                    this.capitulos[i] = value;
                }
            }
        }

        public string Titulo
        {
            get
            {
                return this.titulo;
            }
        }

        public string Autor
        {
            get
            {
                return this.autor;
            }
        }
        #endregion

        public Libro(string titulo, string autor)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.capitulos = new List<Capitulo>();
        }
    }
}
