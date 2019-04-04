using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProducto
{
    class Estante
    {
        private Producto[] productos;
        int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad,int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante estante)
        {
            string datosEstante = "";

            if(!Object.ReferenceEquals(estante, null))
            {
                foreach (Producto auxiliar in estante.productos)
                {
                    datosEstante += Producto.MostrarProducto(auxiliar);
                }
            }
            return datosEstante; 
        }
        public static bool operator !=(Estante estante,Producto producto)
        {
            return !(estante == producto);
        }
        public static bool operator ==(Estante estante, Producto producto)
        {
            if (estante.productos.Contains(producto))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator +(Estante estante, Producto producto)
        {
            bool valorRetorno = false;
            int i;

            if(estante != producto)
            {
                for(i = 0;i < estante.productos.Length;i++)
                {
                    if(Object.ReferenceEquals(estante.productos[i], null))
                    {
                        estante.productos[i] = producto;
                        valorRetorno = true;
                        break;
                    }
                }
            }
            return valorRetorno;
        }
        public static Estante operator -(Estante estante, Producto producto)
        {
            int i;

            if (estante == producto)
            {
                for (i = 0; i < estante.productos.Length; i++)
                {
                    if (Object.ReferenceEquals(estante.productos[i], producto))
                    {
                        estante.productos[i] = null;
                        break;
                    }
                }
            }
            return estante;
        }
    }
}
