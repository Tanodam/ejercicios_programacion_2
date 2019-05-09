using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Padre
    {
        protected float atributoUno;
        protected string atributoDos;
        protected string atributoTres;

        #region Propiedades

        public float AtributoUno
        {
            get
            {
                return this.atributoUno;
            }
            set
            {
                this.atributoUno = value;
            }
        }

        public string AtributoDos
        {
            get
            {
                return this.atributoDos;
            }
            set
            {
                this.atributoDos = value;
            }
        }

        public string AtributoTres
        {
            get
            {
                return this.atributoTres;
            }
            set
            {
                this.atributoTres = value;
            }
        }

        #endregion

        #region Métodos

        public Padre()
        { }

        public Padre(float atributoUno, string atributoDos, string atributoTres)
        {
            this.AtributoUno = atributoUno;
            this.AtributoDos = atributoDos;
            this.AtributoTres = atributoTres;
        }

        /// <summary>
        /// Método que muestra todos los datos del objeto
        /// </summary>
        /// <returns>Retorna los datos en un string</returns>
        protected virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat("AtributoUno: {0} min \n", this.AtributoUno.ToString());
            datos.AppendFormat("AtributoDos: {0} \n", this.AtributoDos);
            datos.AppendFormat("AtributoTres: {0} \n", this.AtributoTres);

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
            return Tuple.Create(atributoUno, atributoDos, atributoTres).GetHashCode();
        }
        #endregion
    }
}