using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04.Entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            return $"{this.entero} - {this.cadena} - {this.fecha}\n";
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entero"></param>
        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cadena"></param>
        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fecha"></param>
        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public Cosa()
        {
            this.entero = -1;
            this.cadena = "Sin Valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(string cadena):this() // Constructor:this() SOLO PARA CONSTRUCTORES
        {
          //  this.entero = -1;
            this.cadena = cadena;
           // this.fecha = DateTime.Now;
        }

        public Cosa(string cadena, DateTime fecha):this(cadena)
        {
           // this.entero = -1;
           // this.cadena = cadena;
            this.fecha = DateTime.Now;
        }
      
        public Cosa(string cadena, DateTime fecha, int entero):this(cadena, fecha)
        {
         //   this.entero = entero;
        //    this.cadena = cadena;
            this.fecha = fecha;

        }
    }
}
