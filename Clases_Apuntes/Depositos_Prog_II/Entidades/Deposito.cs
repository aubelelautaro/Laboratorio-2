using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Deposito<T>
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<T> _lista;
        #endregion

        #region Constructores
        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }
        #endregion


        #region Metodos
        private int GetIndice(T a)
        {
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i].Equals(a))
                    return i;
            }
            return -1;
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad Maxima: {this._capacidadMaxima}");
            sb.AppendLine($"Listado de {typeof(T).Name}"+ "s");
            foreach (T value in this._lista)
            {
                sb.AppendLine(value.ToString());
            }
            return sb.ToString();
        }
        #endregion


        #region Sobrecarga de Operadores
        public static bool operator +(Deposito<T> d, T a)
        {
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                return true;
            }
            return false;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            int indice = d.GetIndice(a);

            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                return true;
            }

            return false;
        }
        #endregion
    }
}
