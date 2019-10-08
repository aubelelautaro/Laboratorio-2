using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        #region Atributos
        private const int cantidadMaximaDeJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;
        #endregion

        #region Propiedades
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidadAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        #region Constructor
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Sobrecarga de Operadores
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"EQUIPO: {e.nombre}");
            sb.AppendLine($"CANTIDAD DE JUGADORES: {cantidadMaximaDeJugadores}");
            if(!(e.directorTecnico is null))
            {
                sb.AppendLine(e.directorTecnico.Mostrar());
            }
            else
            {
                sb.AppendLine("SIN DT");
                sb.AppendLine("********************");
            }
            foreach(Jugador j in e.jugadores)
            {
                sb.AppendLine(j.Mostrar());
            }
            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            if(!(e is null) && !(j is null))
            {
                foreach(Jugador jugador in e.jugadores)
                {
                    if(jugador == j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e.jugadores.Count < cantidadMaximaDeJugadores && e != j 
                && j.ValidadAptitud())
            {
                e.jugadores.Add(j);
            }
            return e;
        }
        #endregion

        #region Metodos
        public static bool ValidarEquipo(Equipo e)
        {
            bool retorno = false;
            int contArquero = 0;
            int contDefensor = 0;
            int contCentral = 0;
            int contDelantero = 0;

            if(!(e.directorTecnico is null))
            {
                if(e.jugadores.Count == cantidadMaximaDeJugadores)
                {
                    foreach(Jugador j in e.jugadores)
                    {
                        if(j.Posicion is Posicion.Arquero)
                        {
                            contArquero++;
                        }

                        if(j.Posicion is Posicion.Defensor)
                        {
                            contDefensor++;
                        }

                        if(j.Posicion is Posicion.Delantero)
                        {
                            contDelantero++;
                        }

                        if(j.Posicion is Posicion.Central)
                        {
                            contCentral++;
                        }
                    }
                }

                if(contArquero == 1 && contCentral > 0 && contDefensor > 0 && contDelantero > 0)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        #endregion
    }
}
