using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        #region Atributos
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;
        #endregion

        #region Constructores
        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible):this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region Sobrecarga De Operadores
        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**************************");
            sb.AppendLine($"Estacionamiento: {e.nombre}");
            sb.AppendLine($"Espacio Disponible: {e.espacioDisponible}");
            sb.AppendLine("**************************");
            sb.AppendLine("Vehiculos:");
            sb.AppendLine("**************************");
            foreach (Vehiculo v in e.vehiculos)
            {
                sb.AppendLine(v.ConsultarDatos());
            }
            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(!(estacionamiento is null) && !(vehiculo is null))
            {
                foreach(Vehiculo value in estacionamiento.vehiculos)
                {
                    if(value == vehiculo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento.espacioDisponible > estacionamiento.vehiculos.Count)
            {
                if(estacionamiento != vehiculo && !string.IsNullOrEmpty(vehiculo.Patente))
                {
                    estacionamiento.vehiculos.Add(vehiculo);
                }
            }
            return estacionamiento;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento != vehiculo)
            {
                return "El vehiculo no es parte del estacionamiento";
            }
            else
            {
                estacionamiento.vehiculos.Remove(vehiculo);
                return vehiculo.ImprimirTicket();
            }
        }
        #endregion
    }
}
