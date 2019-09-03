using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05_Ejercicio
{
    class Estante
    {
        Producto[] productos;
        int ubicacionEstante;


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];

            //for(int i = 0; i < this.productos.Length; i++)
            //{
            //    this.productos[i];
            //}
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
           
                string retorno = $"\"Ubicacion Estante\" {e.ubicacionEstante}\n\n";

                foreach (Producto prod in e.productos)
                {
                    if (!string.IsNullOrEmpty(Producto.MostrarProducto(prod)))
                    {
                        retorno += Producto.MostrarProducto(prod);
                    }
                }

                return retorno;
            
            
        }

        public static bool operator ==(Estante e, Producto p)
        {
            for(int i = 0; i < e.productos.Length; i++)
            {
                if (p.Equals(e.productos[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (p.Equals(e.productos[i]))
                {
                    return false;
                }
            }
            return true;

           
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (e == p)
                return false;
            else
            {
                for (int i = 0; i<e.productos.Length;i++)
                {
                    if (null == e.productos[i])
                    {
                        e.productos[i] = p;
                        return true;
                    }

                }
                return false;
            }
        }
            

        public static Estante operator -(Estante e, Producto p)
        {
            if(e == p)
            {
                p = null;
                return e;
            }


            return e;
            
        }
        
    }
}
