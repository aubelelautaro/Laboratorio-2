using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        #region Atributos
        protected DateTime ingreso;
        private string patente;
        #endregion

        #region Propiedades
        public string Patente
        {
            get
            {
                return this.patente;
            }

            set
            {
                if(value.Length == 6)
                {
                    this.patente = value;
                }
                else
                {
                    this.patente = string.Empty;
                }
            }
        }
        #endregion

        #region Constructores
        public Vehiculo(string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }
        #endregion

        #region Metodos
        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return string.Format("Patente {0}", this.patente);
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendLine($"Fecha De Ingreso: {this.ingreso}");
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga De Operadores
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if(!(v1 is null) && !(v2 is null))
            {
                if(string.Compare(v1.patente, v2.patente) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion


    }
}
