using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        /// <summary>
        /// Propiedad de solo lectura que setea el atributo Fecha
        /// </summary>
        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        /// <summary>
        /// Calculará el precio final multiplicando el precio unitario por la cantidad comprada sumando el IVA
        /// </summary>
        /// <param name="precioUnidad">Precio unitario</param>
        /// <param name="cantidad">Cantidad comprada</param>
        /// <returns></returns>
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioCompra = (precioUnidad * cantidad);
            double porcentajeCompra = (precioCompra * porcentajeIva) / 100;

            return precioCompra += porcentajeCompra;
        }

        /// <summary>
        /// Método que muestra une descripción del producto
        /// </summary>
        /// <returns>Devuelve los datos en un solo string</returns>
        public string ObtenerDescripcionBreve()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat("Fecha {0} - descripción {1} ",this.Fecha,this.producto.Descripcion);
            datos.AppendFormat("- precioFinal ${0}",this.precioFinal);

            return datos.ToString();
        }

        /// <summary>
        /// Método que resta del stock según cantidad a vender
        /// </summary>
        /// <param name="cantidad">Cantidad a vender</param>
        private void Vender(int cantidad)
        {
            this.fecha = DateTime.Now;
            this.producto.Stock -= cantidad;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);
        }

        /// <summary>
        /// Constructor privado que setea el atributo estático
        /// </summary>
        private Venta()
        {
            porcentajeIva = 21;
        }

        /// <summary>
        /// Constructor que setea los atributos de producto y llama al método vender
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        internal Venta(Producto producto, int cantidad):this()
        {
            this.producto = producto;

            this.Vender(cantidad);
        }
    }
}
