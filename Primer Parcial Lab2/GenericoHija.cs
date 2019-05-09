using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hija : Padre
    {
        private string atributoCuatro;
        int array;

        #region Propiedades

        public float AtributoCuatro
        {
            get
            {
                return this.atributoCuatro;
            }
            set
            {
                this.atributoCuatro = value;
            }
        }

        #endregion

        #region Métodos

        public Hija(float atributoUno, string atributoDos, string atributoTres, string atributoCuatro)
        : base(atributoUno, atributoDos, atributoTres)
        {
            this.AtributoCuatro = atributoCuatro;
        }

        /// <summary>
        /// Método que muestra todos los datos del objeto
        /// </summary>
        /// <returns>Retorna los datos en un string</returns>
        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendLine(base.Mostrar());
            datos.AppendFormat("AtributoCuatro: {0} \n", this.AtributoCuatro);

            return datos.ToString();
        }
        #endregion

        #region Operadores

        public static bool operator ==(Padre elementoUno, Padre elementoDos)
        {
            return true;
        }

        public static bool operator !=(Padre elementoUno, Padre elementoDos)
        {
            return !(elementoUno == elementoDos);
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
            return Tuple.Create(atributoCuatro).GetHashCode();
        }
        #endregion
    }
}