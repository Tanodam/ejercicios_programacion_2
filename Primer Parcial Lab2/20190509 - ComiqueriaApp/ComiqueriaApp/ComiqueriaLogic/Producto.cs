using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        /// <summary>
        /// Propiedad de solo lectura que retorna la descripción de un producto
        /// </summary>
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura que retorna el precio de un producto
        /// </summary>
        public double Precio
        {
            get
            {
                return this.precio;     
            }
        }

        /// <summary>
        /// Propiedad de solo lectura que retorna el stock de un producto
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        /// <summary>
        /// Constructor que setea los campos de un producto
        /// </summary>
        /// <param name="descripcion">Descripción de un producto</param>
        /// <param name="stock">Stock de un producto</param>
        /// <param name="precio">Precio de un producto</param>
        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }

        /// <summary>
        /// Operador que recibe un producto y devuelve su código como objeto GUID
        /// </summary>
        /// <param name="producto">Producto para retornar el código</param>
        public static explicit operator Guid(Producto producto)
        {
            if(producto != null)
            {
                return producto.codigo;
            }
            return new Guid();
        }

        /// <summary>
        /// Muestra todos los datos de un productos 
        /// </summary>
        /// <returns>Retorna todos los datos en un solo string</returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat("Descripcion: {0}\n", this.Descripcion);
            datos.AppendFormat("Código: {0}\n", this.codigo.ToString());
            datos.AppendFormat("Precio: ${0}\n", this.Precio);
            datos.AppendFormat("Stock: {0} unidades\n", this.Stock);

            return datos.ToString();
        }
    }
}
