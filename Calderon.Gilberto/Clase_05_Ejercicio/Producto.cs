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

          //  if(p != null)
         //   {
                 return $"Producto:\n--> Marca: {p.marca}\n--> Precio: {p.precio}\n--> Codigo De Barra: {p.codigoDeBarra}\n";

           // }
          //  return "Vacio";
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Producto)
                {
                    Producto temp = (Producto)obj;
                    if (temp.precio == this.precio
                        && temp.marca == this.marca)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return this.marca.GetHashCode() ^ this.precio.GetHashCode() ^ this.codigoDeBarra.GetHashCode();
            }
        }

        public static bool operator ==(Producto p1, Producto p2)
        { 
            if(p1 is Producto && p2 is Producto)
            {
                if(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            if (p1 is Producto && p2 is Producto)
            {
                if (p1.marca != p2.marca && p1.codigoDeBarra != p2.codigoDeBarra)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        public static bool operator ==(Producto p, string marca)
        {
            if (!string.IsNullOrEmpty(marca))
            {
                if(p.marca == marca)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            return false;
        }

        public static bool operator !=(Producto p, string marca)
        {
            if (!string.IsNullOrEmpty(marca))
            {
                if (p.marca == marca)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            return false;
        }
    }
}
