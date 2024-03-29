﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        #region atributos
        private byte nota1;
        private byte nota2;
        public string nombre;
        public string apellido;
        public float notaFinal;
        public int legajo;
        #endregion


        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void CalcularFinal()
        {
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random nota = new Random();
                this.notaFinal = nota.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            if(this.notaFinal != -1)
            {
                return $"Nombre->{this.nombre}; Apellido-> {this.apellido}; Legajo-> {this.legajo}; Alumno Aprobado";
            }
            else
            {
                return "Alumno Desaprobado";
            }
        }
    }
}
