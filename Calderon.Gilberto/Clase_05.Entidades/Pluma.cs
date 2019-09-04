using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma()
        {
            this._cantidad = 0;
            this._marca = "Sin marca";
            this._tinta = null;
        }

        public Pluma(string marca):this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, Tinta tinta):this(marca)
        {
            this._tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            this._cantidad = cantidad;
        }

        private string Mostrar()
        {
            return $"Tinta: {(string)this._tinta} Marca: {this._marca} Cantidad: {this._cantidad}\n";
        }

        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator  ==(Pluma pluma, Tinta tinta)
        {
            return (pluma._tinta == tinta);
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma._tinta == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if(!Object.Equals(pluma, null) && !Object.Equals(tinta, null))
            {
                if (pluma._cantidad < 100)
                {
                    if(pluma._tinta == tinta)
                    {
                        pluma._cantidad++;
                        return pluma;
                    }
                }
            }

            return pluma;
        }
    }
}
