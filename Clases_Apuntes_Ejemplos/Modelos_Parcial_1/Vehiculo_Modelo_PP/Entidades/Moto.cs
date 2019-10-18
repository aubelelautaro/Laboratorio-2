using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto:Vehiculo
    {
        #region Atributos
        private int cilindrada;
        private short ruedas;
        private static int valorHora;
        #endregion

        #region Constructores
        static Moto()
        {
            Moto.valorHora = 30;
        }

        public Moto(string patente, int cilindrada):this(patente, cilindrada, 2)
        {

        }
        
        public Moto(string patente, int cilindrada, short ruedas):this(patente, cilindrada, ruedas, Moto.valorHora)
        {

        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora):base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
            Moto.valorHora = valorHora;
        }
        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {
            if(!(obj is null))
            {
                if(obj is Moto)
                {
                    if(this == (Moto)obj)
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Moto");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            sb.AppendLine($"Ruedas: {this.ruedas}");
            sb.AppendLine($"Valor Hora: {Moto.valorHora}");
            sb.AppendLine("**************************");
            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ticket Moto");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Valor de estadia: {(DateTime.Now - this.ingreso).Hours * Moto.valorHora}");
            sb.AppendLine("**************************");
            return sb.ToString();
        }
        #endregion
    }
}
