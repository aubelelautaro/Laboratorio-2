using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Auto:Vehiculo
    {
        protected string _patente;

        public override double Precio
        {
            get
            {
                return this._precio;
            }
        }

        public string Patente
        {
            get
            {
                return this._patente;
            }
        }

        public Auto(double precio, string patente):base(precio)
        {
            this._patente = patente;
        }

        public void MostrarPatente()
        {
            Console.WriteLine("Patente: {0}", this._patente);
        }
    }
}
