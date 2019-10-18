using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        #endregion

        public float GananciaPorLocal
        {
            get
            {
                float ganacia = 0;
                foreach (Llamada value in this._listaDeLlamadas)
                {
                    if (value is Local)
                    {
                        ganacia += value.CostoLlamada;
                    }
                }
                return ganacia;
            }
        }

        public float GananciaProvincial
        {
            get
            {
                float ganancia = 0;
                foreach (Llamada value in this._listaDeLlamadas)
                {
                    if (value is Provincial)
                    {
                        ganancia += value.CostoLlamada;
                    }
                }
                return ganancia;
            }
        }

        public float GananciaTotal
        {
            get
            {
                return this.GananciaPorLocal + this.GananciaProvincial;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }

        #region Constructores
        public Centralita():this("Empresa Desconocida")
        {

        }

        public Centralita(string  nombreEmpresa)
        {
            this._razonSocial = nombreEmpresa;
            this._listaDeLlamadas = new List<Llamada>();
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            if(!(central is null) && !(nuevaLlamada is null))
            {
                foreach(Llamada value in central._listaDeLlamadas)
                {
                    if (value == nuevaLlamada)
                        return true;
                }
            }

            return false;
        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if(central != nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
            }
            return central;
        }
        #endregion

        #region Metodos
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if(!(nuevaLlamada is null))
                this._listaDeLlamadas.Add(nuevaLlamada);
            return;
        }

        //public void OrdenarLlamadas()
        //{
        //    this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        //}

        public float CalcularGanancia(TipoLlamada tipo)
        {
            if (tipo == TipoLlamada.Local)
            {
                return this.GananciaPorLocal;
            }
            else if(tipo == TipoLlamada.Provincial)
            {
                return this.GananciaProvincial;
            }
            else
            {
                return this.GananciaTotal;
            }
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            if (!Object.ReferenceEquals(this, null))
            {
                sb.AppendLine(this._razonSocial);
                foreach (Llamada value in this._listaDeLlamadas)
                {
                    sb.AppendLine(value.ToString());
                }
              //  sb.AppendLine(string.Join("\n", this._listaDeLlamadas));
            }
            else
            {
                sb.AppendLine("No existe la centralita");
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return  this.Mostrar();
        }

        #endregion

    }
}
