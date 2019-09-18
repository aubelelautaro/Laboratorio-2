using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        /// <summary>
        /// Contructor para un rectangulo.
        /// </summary>
        /// <param name="vertice1"></param>
        /// <param name="vertice3"></param>
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            //////////////////////////////////////////////////////////////////
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
            /////////////////////////////////////////////////////////////////
        }

        /// <summary>
        /// Calcula el area de un rectangulo.
        /// </summary>
        /// <returns></returns>
        public float Area()
        {
            this.area = Math.Abs(this.vertice4.GetX() - this.vertice1.GetX()) * Math.Abs(this.vertice1.GetY() - this.vertice2.GetY());
            return this.area ;
        }

        /// <summary>
        /// Calcula el perimetro de un rectangulo.
        /// </summary>
        /// <returns></returns>
        public float Perimetro()
        {
            this.perimetro = 2 * (Math.Abs(this.vertice4.GetX() - this.vertice1.GetX()) * Math.Abs(this.vertice1.GetY() - this.vertice2.GetY()));
            return this.perimetro;
        }


    }
} 
 
    

