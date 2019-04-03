using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProducto
{
    class Producto
    {
        private String codigoDeBarra;
        private String marca;
        private float precio;

        public Producto(string marca,string codigo,float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
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
        public static string MostrarProducto(Producto producto)
        {
            string datosProducto = "";

            datosProducto += "\nMarca: " + producto.GetMarca();
            datosProducto += "\nPrecio: " + producto.GetPrecio().ToString();
            datosProducto += "\nCodigo de barras: " + (string)producto;

            return datosProducto;
        }

        //Console.Write((string)Producto);

        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }
        public static bool operator !=(Producto producto,string marca)
        {
            return !(producto == marca);// PROBAR producto != marca
        }
        public static bool operator ==(Producto producto, string marca)
        {
            if (producto.GetMarca() == marca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }
        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            if(productoUno.GetMarca() == productoDos.GetMarca() && (string)productoUno == (string)productoDos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
