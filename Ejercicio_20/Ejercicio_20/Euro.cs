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
        float cotizRespectoDolar;

        public Euro()
        {

        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }

        //Operadores
        public static explicit operator Dolar(Euro euros)
        {

        }

        public static explicit operator Pesos(Euro euros)
        {

        }

        public static implicit operator Euro(double dolar)
        {

        }

        public static bool operator !=(Euro euros, Dolar dolar)
        {

        }

        public static bool operator !=(Euro euros, Pesos pesos)
        {

        }

        public static bool operator !=(Euro eurosUno, Euro eurosDos)
        {

        }

        public static bool operator ==(Euro euros, Dolar dolar)
        {

        }

        public static bool operator ==(Euro euros, Pesos pesos)
        {

        }

        public static bool operator ==(Euro eurosUno, Euro eurosDos)
        {

        }

        public static Euro operator -(Euro euros, Dolar dolar)
        {

        }

        public static Euro operator -(Euro euros, Pesos pesos)
        {

        }

        public static Euro operator +(Euro euros, Dolar dolar)
        {

        }

        public static Euro operator +(Euro euros, Pesos pesos)
        {

        }
    }
}
