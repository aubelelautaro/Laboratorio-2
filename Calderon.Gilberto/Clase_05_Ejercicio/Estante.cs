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
                if (e.productos[i] == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e ==p);
        }

        public static bool operator +(Estante e, Producto p)
        { 
            for(int i = 0; i < e.productos.Length; i++)
            {
                if (Object.Equals(e.productos[i], null))
                {
                    e.productos[i] = p;
                    return true;
                }
            }
            return false;
        }
            

        public static Estante operator -(Estante e, Producto p)
        {
            if(e == p)
            {
                for(int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        return e;
                    }
                }
            }
            return e;
        }
        
    }
}
