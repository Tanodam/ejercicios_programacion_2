using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        /// <summary>
        /// Priopiedad de solo lectura que devuelve un producto por código
        /// </summary>
        /// <param name="codigo">Código GUID que recibe para buscar el producto</param>
        /// <returns>Retorna un producto</returns>
        public Producto this[Guid codigo]
        {
            get
            {
                foreach(Producto producto in this.productos)
                {
                    if((Guid)producto == codigo)
                    {
                        return producto;
                    }
                }
                return null;
            }
        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        /// <summary>
        ///  Cada elemento del diccionario  corresponderá con cada producto en la lista de productos.La key será el código del 
        ///  producto y el valor la descripción del producto.
        /// </summary>
        /// <returns>Retorna un Dictionary</returns>
        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> listaProductos = new Dictionary<Guid, string>();

            foreach(Producto producto in this.productos)
            {
                listaProductos.Add((Guid)producto, producto.Descripcion);
            }

            return listaProductos;
        }


        /// <summary>
        /// Lista todas las ventas de la comiqueria
        /// </summary>
        /// <returns>Retorna los datos de las ventas en un string</returns>
        public string ListarVentas()
        {
            StringBuilder datos = new StringBuilder("");

            this.ventas.Sort(CriterioOrdenar);

            foreach (Venta venta in this.ventas)
            {
                datos.AppendLine(venta.ObtenerDescripcionBreve());
            }

            return datos.ToString();
        }

        /// <summary>
        /// Agrega una venta con cantidad 1 por defecto
        /// </summary>
        /// <param name="producto"></param>
        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }

        /// <summary>
        /// Agrega una venta a la lista 
        /// </summary>
        /// <param name="producto">Producto seleccionado</param>
        /// <param name="cantidad">Cantidad a vender</param>
        public void Vender(Producto producto, int cantidad)
        {
            if(cantidad > 0)
            {
                this.ventas.Add(new Venta(producto,cantidad));
            }
        }

        /// <summary>
        /// Operador que busca si existe un producto en la lista de la comiqueria
        /// </summary>
        /// <param name="comiqueria">Comiqueria para buscar el producto</param>
        /// <param name="producto">Producto a buscar</param>
        /// <returns>Retorna true NO lo encuentra sino retorna false</returns>
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        /// <summary>
        /// Operador que busca si existe un producto en la lista de la comiqueria
        /// </summary>
        /// <param name="comiqueria">Comiqueria para buscar el producto</param>
        /// <param name="producto">Producto a buscar</param>
        /// <returns>Retorna true si lo encuentra sino retorna false</returns>
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto productoAuxiliar in comiqueria.productos)
            {
                if (productoAuxiliar.Descripcion == producto.Descripcion)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Agrega un producto a la lista si este no existe
        /// </summary>
        /// <param name="comiqueria">Comiqueria para agregar el producto</param>
        /// <param name="producto">Producto a agregar</param>
        /// <returns></returns>
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }

        /// <summary>
        /// Funcion criterio para ordenar las ventas
        /// </summary>
        /// <param name="ventaUno">Primer venta para comparar</param>
        /// <param name="ventaDos">Segunda venta para comparar</param>
        /// <returns></returns>
        public int CriterioOrdenar(Venta ventaUno, Venta ventaDos)
        {
            if(ventaUno.Fecha > ventaDos.Fecha)
            {
                return -1;
            }
            else if(ventaUno.Fecha < ventaDos.Fecha)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
