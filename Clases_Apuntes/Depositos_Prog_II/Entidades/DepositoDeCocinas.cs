using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<Cocina> _lista;
        #endregion

        #region Constructores
        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }
        #endregion


        #region Metodos
        private int GetIndice(Cocina c)
        {
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i].Equals(c))
                    return i;
            }
            return -1;
        }

        public bool Agregar(Cocina c)
        {
            return this + c;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad Maxima: {this._capacidadMaxima}");
            sb.AppendLine("Listado de Cocinas:");
            foreach (Cocina value in this._lista)
            {
                sb.AppendLine(value.ToString());
            }
            return sb.ToString();
        }
        #endregion


        #region Sobrecarga de Operadores
        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(c);
                return true;
            }
            return false;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            int indice = d.GetIndice(c);

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
