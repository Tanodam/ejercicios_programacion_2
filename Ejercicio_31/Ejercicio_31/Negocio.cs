using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        #region Propiedades

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                if(!clientes.Contains(value))
                {
                    clientes.Enqueue(value);
                }
            }
        }

        public byte ClientesPendientes
        {
            get
            {
                return (byte)this.clientes.Count;
            }
        }

        #endregion

        #region Constructores

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        #endregion

        #region Operadores

        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);
        }

        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            if(negocio.clientes.Contains(cliente))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ~(Negocio negocio)
        {
            if(negocio.caja.Atender(negocio.Cliente))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            foreach(Cliente clienteAux in negocio.clientes)
            {
                if(clienteAux == cliente)
                {
                    return false;
                }
            }
            negocio.clientes.Enqueue(cliente);
            return true;
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
            return Tuple.Create(caja, clientes, nombre).GetHashCode();
        }
        #endregion
    }
}
