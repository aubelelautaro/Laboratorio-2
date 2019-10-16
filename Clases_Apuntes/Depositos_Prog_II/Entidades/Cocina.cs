using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        #region Atributos
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;
        #endregion

        #region Propiedades
        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }

        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }

        public  double Precio
        {
            get
            {
                return this._precio;
            }
        }
        #endregion

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        #region Sobrecarga de Operadores
        public static bool operator ==(Cocina a, Cocina b)
        {
            if(!(a is null) && !(b is null))
            {
                if(a._codigo == b._codigo)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {
            if(obj is Cocina)
            {
                if(this == (Cocina)obj)
                {
                    return true;
                }      
            }
            return false;
        }

        public override string ToString()
        {
            return $"Codigo: {this._codigo} - Precio: {this._precio} - Es industrial? : {this._esIndustrial}";
        }
        #endregion 
    }
}
