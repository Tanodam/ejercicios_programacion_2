using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        /// <summary>
        /// Tipos de comics
        /// </summary>
        public enum TipoComic
        {
            Occidental,
            Oriental
        };

        private string autor;
        private TipoComic tipoComic;

        /// <summary>
        /// Constructor que setea los atributos de un objeto Comic
        /// </summary>
        /// <param name="descripcion">Valor para el atributo descripción</param>
        /// <param name="stock">Valor para el atributo stock</param>
        /// <param name="precio">Valor para el atributo precio</param>
        /// <param name="autor">Valor para el atributo autor</param>
        /// <param name="tipoComic">Valor para el atributo tipoComic</param>
        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic)
            : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        /// <summary>
        /// Sobrecarga del método ToString que retorna los datos de un objeto Comic
        /// </summary>
        /// <returns>Devuelve los datos en un string</returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat(base.ToString());
            datos.AppendFormat("Autor: {0}\n", this.autor);
            datos.AppendFormat("Tipo de comic: {0}\n", this.tipoComic);

            return datos.ToString();
        }
    }
}
