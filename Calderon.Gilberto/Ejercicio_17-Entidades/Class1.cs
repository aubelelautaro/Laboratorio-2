using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17_Entidades
{
    /// <summary>
    /// Clase creada para la realizacion del ejercicio 17
    /// </summary>
    public class Boligrafo
    {
        #region Atributos
        private const short cantidadTintaMaxima = 100;
        private short tinta;
        private ConsoleColor color;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <param name="tinta"></param>
        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.tinta = tinta;
            this.color = color;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            
            if(tinta > 0)
            {
                this.tinta -= tinta;
            }
           
            // se valida el nivel de tinta
            if(this.tinta < 0)
            {
                this.tinta = 0;
            }
          
            if(this.tinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }

        //public bool Pintar(int gasto, out string dibujo)
        //{
        //    dibujo = "";
            
        //    SetTinta((short)gasto);

        //    if(gasto > this.tinta)
        //    {
        //       for(int i = 0; i < this.tinta; i++)
        //       {
        //           dibujo += "*";
        //       }
        //       return false;
        //    }

        //    if(this.tinta >= gasto)
        //    {
        //      for (int i = 0; i < gasto; i++)
        //      {
        //          dibujo += "*";
        //      }

        //      return true;
        //    }

            
            
           
        //}



    }
}
