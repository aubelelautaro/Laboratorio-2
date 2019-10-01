using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37.Entidades
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        #endregion


        #region Constructores
        public Centralita() : this("Empresa Desconocida")
        {

        }

        public Centralita(string nombreEmpresa)
        {
            this._razonSocial = nombreEmpresa;
            this._listaDeLlamadas = new List<Llamada>();
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            bool retorno = false;
            if (!Object.ReferenceEquals(central, null) && !Object.ReferenceEquals(nuevaLlamada, null))
            {
                foreach (Llamada value in central._listaDeLlamadas)
                {
                    if (value == nuevaLlamada)
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if (central != nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
            }
            return central;
        }
        #endregion

        #region Metodos
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
            return;
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
            return this.Mostrar();
        }

        #endregion
    }
}
