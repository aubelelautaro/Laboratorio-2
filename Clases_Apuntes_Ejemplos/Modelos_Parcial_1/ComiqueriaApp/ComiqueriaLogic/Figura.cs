using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura: Producto
    {
        #region Atributos
        private double altura;
        #endregion

        #region Constructores
        public Figura(int stock, double precio,double altura):this($"Figura: {altura} cm",stock , precio, altura)
        {

        }

        public Figura(string descripcion, int stock, double precio, double altura):base(descripcion, stock, precio)
        {
            this.altura = altura;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.altura}");
            return base.ToString() + sb.ToString();
        }
        #endregion

    }
}
