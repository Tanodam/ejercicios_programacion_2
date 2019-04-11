using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        double cantidad;
        static float cotizRespectoDolar;

        public Euro()
        {
            cotizRespectoDolar = 1.16f;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        //Operadores
        public static explicit operator Dolar(Euro euros)
        {
            return (euros.GetCantidad() / cotizRespectoDolar);
        }

        public static explicit operator Pesos(Euro euros)
        {
            return ((Dolar)euros).GetCantidad() / Pesos.GetCotizacion();
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        public static bool operator !=(Euro euros, Dolar dolar)
        {
            return !(euros == dolar);
        }

        public static bool operator !=(Euro euros, Pesos pesos)
        {
            return !(euros == pesos);
        }

        public static bool operator !=(Euro eurosUno, Euro eurosDos)
        {
            return !(eurosUno == eurosDos);
        }

        public static bool operator ==(Euro euros, Dolar dolar)
        {
            if (euros.GetCantidad() == (dolar.GetCantidad() / cotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Euro euros, Pesos pesos)
        {
            if (euros.GetCantidad() == (pesos.GetCantidad() / cotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Euro eurosUno, Euro eurosDos)
        {
            if (eurosUno.GetCantidad() == eurosDos.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Euro operator -(Euro euros, Dolar dolar)
        {
            return euros.GetCantidad() - dolar.GetCantidad() / cotizRespectoDolar;
        }

        public static Euro operator -(Euro euros, Pesos pesos)
        {
            return euros.GetCantidad() - pesos.GetCantidad() / cotizRespectoDolar;
        }

        public static Euro operator +(Euro euros, Dolar dolar)
        {
            return euros.GetCantidad() + dolar.GetCantidad() / cotizRespectoDolar;
        }

        public static Euro operator +(Euro euros, Pesos pesos)
        {
            return euros.GetCantidad() + pesos.GetCantidad() / cotizRespectoDolar;
        }
    }
}
