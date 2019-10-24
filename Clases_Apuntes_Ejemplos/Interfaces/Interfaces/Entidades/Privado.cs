using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Privado:Avion
    {
        protected int _valoracionDeServicioDeAbordo;

        public Privado(double precio, double velocidad, int valoracion):base(precio, velocidad)
        {
            this._valoracionDeServicioDeAbordo = valoracion;
        }
    }
}
