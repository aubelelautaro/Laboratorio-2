using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic:Producto
    {
        #region Atributos
        private string autor;
        private TipoComic tipoComic;
        #endregion

        #region Constructores
        public Comic(string descripcion, int stock, double precio, string autor,TipoComic tipoComic):
            base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }
        #endregion

        #region Tipos Anidados
        public enum TipoComic
        {
            Occidental,
            Oriental
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Autor: {this.autor}");
            sb.AppendLine($"Tipo Comic: {this.tipoComic}");
            return base.ToString() + sb.ToString();
        }
        #endregion
    }
}
