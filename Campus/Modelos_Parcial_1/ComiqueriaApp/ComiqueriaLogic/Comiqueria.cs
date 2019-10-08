using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        #region Atributos
        private List<Producto> productos;
        private List<Venta> ventas;
        #endregion

        #region Constructores
        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
        #endregion


        #region Indexador
        public Producto this[Guid codigo]
        {
            get
            {
                foreach(Producto value in this.productos)
                {
                    if (codigo == (Guid)value)
                    {
                        return value;
                    }   
                }
                return null;
            }
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            if (!(comiqueria is null) && !(producto is null))
            {
                foreach (Producto value in comiqueria.productos)
                {
                    if (string.Compare(value.Descripcion, producto.Descripcion) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
                if(comiqueria != producto)
                {
                    comiqueria.productos.Add(producto);
                }
            
            return comiqueria;
        }
        #endregion

        #region Metodos
        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);

            return;
        }

        public void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));

            return;
        }

        public string ListarVentas()
        {
            this.ventas.Sort(Comiqueria.OrdenarPorFecha);
            string cadena = string.Empty;

            foreach(Venta value in this.ventas)
            {
                cadena +=value.ObtenerDescripcionBreve();
                cadena += "\n";
            }

            return cadena;
        }

        public static int OrdenarPorFecha(Venta v1, Venta v2)
        {
            if (v1.Fecha < v2.Fecha)
            {
                return 1;
            }
            else if(v1.Fecha > v2.Fecha)
            {
                return -1;
            }

            return 0;
        }

        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> dic = new Dictionary<Guid, string>();
            foreach (Producto value in this.productos)
            {
                dic.Add((Guid)value, value.Descripcion);
            }

            return dic;
        }
        #endregion

    }
}
