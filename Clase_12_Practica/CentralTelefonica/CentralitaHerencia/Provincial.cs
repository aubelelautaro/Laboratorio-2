using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial: Llamada
    {
        #region Atributos
        protected Franja _franjaHoraria;
        #endregion

        #region Constructor
        public Provincial(Franja miFranja, Llamada unaLlamada)
            :this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(origen, destino, duracion)
        {

        }
        #endregion


        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            float costo = 0;

            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo =  (float)(0.99 * this.Duracion);
                    break;

                case Franja.Franja_2:
                    costo = (float)(1.25 * this.Duracion);
                    break;

                case Franja.Franja_3:
                    costo = (float)(0.66 * this.Duracion);
                    break;
            }

            return costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" Franja Horaria: " + this._franjaHoraria.ToString() + " Costo: " + this.CalcularCosto());
            return base.Mostrar() + sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return !Object.ReferenceEquals(this,null) ? this.Mostrar(): "Llama local inexistente";
        }

        #endregion
    }
}
