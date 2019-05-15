using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        private double altura;

        /// <summary>
        /// Constructor que setea los campos de un objeto Figura con descripcion por defecto
        /// </summary>
        /// <param name="stock">Valor para el atributo stock</param>
        /// <param name="precio">Valor para el atributo precio</param>
        /// <param name="altura">Valor para el atributo altura</param>
        public Figura(int stock, double precio, double altura) : this("Figura "+altura+" cm",stock,precio,altura)
        {
        }

        /// <summary>
        /// Constructor que setea los campos de un objeto Figura con descripcion por defecto
        /// </summary>
        /// <param name="descripcion">Valor para el atributo descripción</param>
        /// <param name="stock">Valor para el atributo stock</param>
        /// <param name="precio">Valor para el atributo precio</param>
        /// <param name="altura">Valor para el atributo altura</param>
        public Figura(string descripcion, int stock, double precio, double altura)
              : base(descripcion, stock, precio)
        {
            this.altura = altura;
        }

        /// <summary>
        /// Sobrecarga del método ToString que retorna los datos de un objeto Figurar
        /// </summary>
        /// <returns>Devuelve los datos en un string</returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat(base.ToString());
            datos.AppendFormat("Altura: {0}\n", this.altura);

            return datos.ToString();
        }
    }
}
