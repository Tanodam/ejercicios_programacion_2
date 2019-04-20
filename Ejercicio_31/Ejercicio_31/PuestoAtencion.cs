using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_31
{ 
    public enum Puesto
    {
        Caja1,
        Caja2
    }

    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        #region Propiedades

        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        #endregion

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cliente)
        {
            //COMO VALIDAR QUE EL CLIENTE SEA VALIDO
            if(cliente.Numero > 0)
            {
                Console.Write("\nAtendiendo al cliente {0}...",cliente.Nombre);
                Thread.Sleep(3000);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
