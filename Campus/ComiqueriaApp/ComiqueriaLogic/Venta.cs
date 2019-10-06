using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        #region Atributos
        private DateTime fecha;
        private static int porcentajelva;
        private double precioFinal;
        private Producto producto;
        #endregion


        #region Constructores

        static Venta()
        {
            Venta.porcentajelva = 21;
        }

        public Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }
        #endregion

        #region Propiedades
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }
        #endregion


        #region Metodos
        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double aux = precioUnidad * cantidad;
            return aux + ((aux * Venta.porcentajelva) / 100);
        }

        public string ObtenerDescripcionBreve()
        {
            return string.Format("{0} - {1} - {2}", this.fecha, this.producto.Descripcion, this.precioFinal.ToString("N2"));
        }
        #endregion
    }
}
