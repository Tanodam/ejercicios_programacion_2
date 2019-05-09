using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private List<Padre> lista;
        private string nombre;

        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        #endregion

        #region Métodos

        private Negocio()
        {
            this.lista = new List<Padre>();
        }

        public Negocio(string nombre) : this()
        {
            this.Nombre = nombre;
        }

        /// <summary>
        /// Método que muestra todos los datos del objeto
        /// </summary>
        /// <returns>Retorna los datos en un string</returns>
        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendLine(this.Nombre);

            foreach (Padre auxiliar in this.lista)
            {
                datos.AppendLine(auxiliar.Mostrar());
            }

            return datos.ToString();
        }
        #endregion

        #region Operadores

        public static bool operator ==(Negocio negocio, Padre elemento)
        {
            foreach (Padre auxiliar in negocio.lista)
            {
                if (auxiliar == elemento)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio negocio, Padre elemento)
        {
            return !(negocio == elemento);
        }

        public static Negocio operator +(Negocio negocio, Padre elemento)
        {
            if (negocio != elemento)
            {
                negocio.lista.Add(elemento);
            }
            return negocio;
        }

        public static Negocio operator -(Negocio negocio, Padre elemento)
        {
            if (negocio == elemento)
            {
                negocio.lista.Remove(elemento);
            }
            return negocio;
        }

        public override bool Equals(object objeto)
        {
            if (objeto != null || this.GetType() == objeto.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Tuple.Create(lista, nombre).GetHashCode();
        }
        #endregion
    }
}