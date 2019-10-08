using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        #region Atributos
        private string _nombre;
        private int _legajo;
        private string _apellido;
        private float _nota;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this._nombre;
            }

            set
            {
                this._nombre = value;
            }
        }

        public int Legajo
        {
            get
            {
                return this._legajo;
            }

            set
            {
                this._legajo = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }

            set
            {
                this._apellido = value;
            }
        }

        public float Nota
        {
            get
            {

                return this._nota;
            }

            set
            {
                this._nota = value;
            }
        }
        #endregion

        #region Constructores
        public Alumno()
        {
            this._nombre = string.Empty;
            this._apellido = string.Empty;
            this._nota = 0;
            this._legajo = 0;
        }

        public Alumno(int legajo) : this()
        {
            this._legajo = legajo;
        }

        public Alumno(int legajo, string nombre) : this(legajo)
        {
            this._nombre = nombre;
        }

        public Alumno(int legajo, string nombre, string apellido) : this(legajo, nombre)
        {
            this._apellido = apellido;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}, {1} - Legajo: {2} - Nota: {3}\n", this._apellido, this._nombre, this._legajo, this._nota);
            return sb.ToString();
        }

        public static string Mostrar(Alumno a)
        {
            return a.Mostrar();
        }
        #endregion

        #region SobreCarga De Operadores
        public static bool operator ==(Alumno a1, Alumno a2)
        {
            return a1._legajo == a2._legajo;
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
