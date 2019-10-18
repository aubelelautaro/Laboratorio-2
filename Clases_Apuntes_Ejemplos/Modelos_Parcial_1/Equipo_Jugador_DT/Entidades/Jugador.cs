using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador:Persona
    {
        #region Atributos
        private float altura;
        private float peso;
        private Posicion posicion;
        #endregion

        #region Propiedades
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        #endregion

        #region Constructores
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura,Posicion posicion)
            :base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JUGADOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Altura: {this.altura}");
            sb.AppendLine($"Peso: {this.peso}");
            sb.AppendLine($"Posicion: {this.posicion}");
            sb.AppendLine("******************************");
            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            float imc = this.peso / (this.altura * this.altura);
            return imc >= 18.5 && imc <= 25;
        }

        public override bool ValidadAptitud()
        {
            return this.ValidarEstadoFisico() && this.Edad <= 40;
        }
        #endregion
    }
}
