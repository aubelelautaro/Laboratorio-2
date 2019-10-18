using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp:Vehiculo
    {
        #region Atributos
        private string modelo;
        private static int valorHora;
        #endregion

        #region Constructores
        static PickUp()
        {
            PickUp.valorHora = 70;
        }

        public PickUp(string patente, string modelo):this(patente, modelo, PickUp.valorHora)
        {

        }

        public PickUp(string patente, string modelo, int valorHora):base(patente)
        {
            this.modelo = modelo;
            PickUp.valorHora = valorHora;
        }
        #endregion


        #region Metodos
        public override bool Equals(object obj)
        {
            if(!(obj is null))
            {
                if(obj is PickUp)
                {
                    if(this == (PickUp)obj)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PICK-UP:");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Valor Hora: {PickUp.valorHora}");
            sb.AppendLine("**************************");
            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ticket Pick Up");
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine($"Costo de estadia: {(DateTime.Now - this.ingreso).Hours * PickUp.valorHora}");
            sb.AppendLine("**************************");
            return sb.ToString();
        }
        #endregion
    }
}
