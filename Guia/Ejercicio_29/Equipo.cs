using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre):this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidad;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (!(e is null) && !(j is null))
            {
                if(e.jugadores.Count < e.cantidadDeJugadores)
                {
                    foreach (Jugador value in e.jugadores)
                    {
                        if (value == j)
                            return false;
                    }
                    e.jugadores.Add(j);
                    return true;
                }
            }
            return false;
        }


    }
}
