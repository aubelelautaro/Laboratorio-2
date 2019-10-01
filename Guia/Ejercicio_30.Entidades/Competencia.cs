using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30.Entidades
{
    public class Competencia
    {
        #region Atributos
        private short cantidadDeCompetidores;
        private short cantidadDeVueltas;
        private List<AutoF1> competidores;
        #endregion

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadDeVueltas, short cantidadDeCompetidores):this()
        {
            this.cantidadDeVueltas = cantidadDeVueltas;
            this.cantidadDeCompetidores = cantidadDeCompetidores;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            if (!(c is null) && !(a is null))
            {
                if (c.competidores.Contains(a))
                    return true;
            }

            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c != a)
            {
                if(c.competidores.Count < c.cantidadDeCompetidores)
                {
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadDeVueltas;
                    a.CantidadDeCombustible = (short)new Random().Next(15, 101);

                    c.competidores.Add(a);
                    return true;
                }
            }
            return false;
        }

        public static bool operator -(Competencia c , AutoF1 a)
        {
            if(c == a)
            {
                if (c.competidores.Remove(a))
                {
                    return true;
                }
            }

            return false;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Competencia:");
            sb.AppendLine($"Hay {this.competidores.Count} competidores de un total de {this.cantidadDeCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadDeVueltas}");
            sb.AppendLine("************************************************************************\n");
            foreach(AutoF1 a in this.competidores)
            {
                sb.AppendLine(a.MostrarDatos());
            }

            return sb.ToString();
        }
    }
}
