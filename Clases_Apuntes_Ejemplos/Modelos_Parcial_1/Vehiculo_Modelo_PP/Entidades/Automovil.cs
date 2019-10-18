using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil:Vehiculo
    {
        #region Atributos
        private ConsoleColor color;
        private static int valorHora;
        #endregion

        #region Constructores
        static Automovil()
        {
            Automovil.valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) : this(patente, color, Automovil.valorHora)
        {
            
        }

        public Automovil(string patente, ConsoleColor color, int valorHora):base(patente)
        {
            this.color = color;
            Automovil.valorHora = valorHora;
        }
        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {
            if(!(obj is null))
            {
                if(obj is Automovil)
                {
                    if(this ==  (Automovil)obj)
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
            sb.AppendLine("Automovil: ");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Color :{this.color}");
            sb.AppendLine($"Valor Hora: {Automovil.valorHora}");
            sb.AppendLine("**************************");
            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ticket Automovil");
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine($"Costo de estadia: {(DateTime.Now - this.ingreso).Hours * Automovil.valorHora}");
            sb.AppendLine("**************************");
            return sb.ToString();
        }
        #endregion
    }
}
