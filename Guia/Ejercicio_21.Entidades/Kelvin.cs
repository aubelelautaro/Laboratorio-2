using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesDeTemperatura
{
    public class Kelvin
    {
        #region Atributos
        private float _temperatura;
        #endregion

        public Kelvin():this(0)
        {

        }

        public Kelvin(float temperatura)
        {
            this._temperatura = temperatura;
        }

        public float GetTemperatura()
        {
            return this._temperatura;
        }

        public static implicit operator Kelvin(float temperatura)
        {
            return new Kelvin(temperatura);
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k._temperatura * 9/5f) - 459.67f);
        }

        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius(((Celsius)((Fahrenheit)k)).GetTemperatura());
        }

    }
}
