using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05_Ejercicio
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;



        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {

            if (!Object.Equals(p, null))
                return $"Producto:\n--> Marca: {p.marca}\n--> Precio: {p.precio}\n--> Codigo De Barra: {p.codigoDeBarra}\n";
            else
                return "No existe";
        }

        public static explicit operator string(Producto p)
        {
            if (!Object.Equals(p, null))
                return p.codigoDeBarra;
            else
                return "Inexistente";
        }

        //public override bool Equals(object obj)
        //{
        //    if (obj != null)
        //    {
        //        if (obj is Producto)
        //        {
        //            Producto temp = (Producto)obj;
        //            if (temp.precio == this.precio
        //                && temp.marca == this.marca)
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    return false;
        //}

        //public override int GetHashCode()
        //{
        //    unchecked
        //    {
        //        return this.marca.GetHashCode() ^ this.precio.GetHashCode() ^ this.codigoDeBarra.GetHashCode();
        //    }
        //}

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!Object.Equals(p1, null) && !Object.Equals(p2, null))
            {
                if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                {
                    return true;
                }

            }
                return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
           
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            if (!string.IsNullOrEmpty(marca) && !Object.Equals(p, null))
            {
                if(p.marca == marca)
                {
                    return true;
                }

            }

            return false;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
    }
}
