using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesDeTemperatura
{
    public class Fahrenheit
    {
        #region Atributos
        private float _temperatura;
        #endregion

        private Fahrenheit():this(0)
        {

        }

        public Fahrenheit(float temperatura)
        {
            this._temperatura = temperatura;
        }

        public float GetTemperatura()
        {
            return this._temperatura;
        }
        
        public static implicit operator Fahrenheit(float temperatura)
        {
            return new Fahrenheit(temperatura);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f._temperatura - 32) * 5 / 9f);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f._temperatura + 459.67f) * 5 / 9f);
        }
    }
}
