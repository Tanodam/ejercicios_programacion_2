using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

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

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        #endregion

        #region Constructores

        public Cliente(int numero)
        {
            
            this.Numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.Nombre = nombre;
        }

        #endregion

        #region Operadores
        public static bool operator !=(Cliente clienteUno, Cliente clienteDos)
        {
            return !(clienteUno == clienteDos);

        }

        public static bool operator ==(Cliente clienteUno, Cliente clienteDos)
        {
            if(clienteUno.Numero == clienteDos.Numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //
        //OVERRIDE EQUALS
        //
        public override bool Equals(object obj)
        {
            if (obj != null || this.GetType() != obj.GetType())
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
            return Tuple.Create(nombre, numero).GetHashCode();
        }

        #endregion

    }
}
