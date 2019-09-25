using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        #region Atributos
        protected float _costo;
        #endregion

        #region Constructores
        public Local(Llamada unaLLamada, float costo)
            :this(unaLLamada.NroOrigen, unaLLamada.Duracion,unaLLamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo):base(origen, destino, duracion)
        {
            this._costo = costo;
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
        protected override string Mostrar()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(" " + this.CostoLlamada.ToString());
            return base.Mostrar() + sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            return this._costo * this._duracion;
        }
        #endregion
    }
}
