﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        #region Atributos
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;
        #endregion

        #region Constructor
        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
            this.dni = 0;
        }

        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        #endregion

        #region Metodos
        public float GetPromedioGoles()
        {
            if(totalGoles != 0)
                this.promedioGoles = (float)this.totalGoles / this.partidosJugados ;
          
            return this.promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: {this.nombre}\n");
            sb.AppendFormat($"Partidos Jugados: {this.partidosJugados}\n");
            sb.AppendFormat($"Promedio de Goles: {this.GetPromedioGoles()}\n");
            sb.AppendFormat($"DNI: {this.dni}\n");
            sb.AppendLine("-----------------------------------");
            return sb.ToString();
        }
        #endregion

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
