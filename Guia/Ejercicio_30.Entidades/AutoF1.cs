using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30.Entidades
{
    public class AutoF1
    {
        #region Atributos
        private short cantidadDeCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        #endregion

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadDeCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"Vueltas Restantes: {this.vueltasRestantes}");
            sb.AppendLine($"Cantidad De Combustible: {this.cantidadDeCombustible}");
            sb.AppendLine("-----------------------------------------------");
            return sb.ToString();
        }

        #region Operadores
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if(string.Compare(a1.escuderia,a2.escuderia) == 0 && a1.numero == a2.numero)
                return true;
            
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion


        #region Propiedades
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public short CantidadDeCombustible
        {
            get
            {
                return this.cantidadDeCombustible;
            }
            set
            {
                this.cantidadDeCombustible = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        #endregion

        public override bool Equals(object obj)
        {
            if(obj is AutoF1)
            {
                if(this == (AutoF1)obj)
                {
                    return true;
                }
            }
           
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return this.escuderia.GetHashCode();
            }
        }

    }
}
