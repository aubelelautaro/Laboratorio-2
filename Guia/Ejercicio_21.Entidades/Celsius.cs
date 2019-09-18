using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesDeTemperatura
{
    public class Celsius
    {
        #region Atributos
        private float _temperatura;
        #endregion

        private Celsius():this(0)
        {

        }

        public Celsius(float temperatura)
        {
            _temperatura = temperatura;
        }

        public float GetTemperatura()
        {
            return this._temperatura;
        }

        public static implicit operator Celsius(float temperatura)
        {
            return new Celsius(temperatura);
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit((c._temperatura * 9 / 5f) + 32);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin(((Kelvin)(Fahrenheit)c).GetTemperatura());
        }
        

    }
}
