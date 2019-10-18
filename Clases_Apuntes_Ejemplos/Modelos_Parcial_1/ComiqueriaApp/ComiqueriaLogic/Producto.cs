using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        #region Atributos
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;
        #endregion

        #region Constructores
        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }
        #endregion

        #region Propiedades
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }

            set
            {
                if(value >= 0)
                {
                    this.stock = value;
                }
            }
        }
        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine($"Descripcion: {this.descripcion}");
            sb.AppendLine($"Codigo: {this.codigo}");
            sb.AppendLine($"Precio: ${this.precio}");
            sb.AppendLine($"Stock: {this.stock}");

            return sb.ToString();

        }

        #endregion

        #region Sobrecargas De Operadores
        public static explicit operator Guid(Producto p)
        { 
           return p.codigo;   
        }
        #endregion

    }
}
