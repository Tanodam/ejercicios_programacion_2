using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        double cantidad;
        float cotizRespectoDolar;

        public Dolar()
        {

        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion) : this(cantidad)
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
        public static explicit operator Euro(Dolar dolares)
        {

        }

        public static explicit operator Pesos(Dolar dolares)
        {

        }

        public static implicit operator Dolar(double dolar)
        {

        }

        public static bool operator !=(Dolar dolares, Euro euros)
        {

        }

        public static bool operator !=(Dolar dolares, Pesos pesos)
        {

        }

        public static bool operator !=(Dolar dolaresUno, Dolar dolaresDos)
        {

        }

        public static bool operator ==(Dolar dolares, Euro euros)
        {

        }

        public static bool operator ==(Dolar dolares, Pesos pesos)
        {

        }

        public static bool operator ==(Dolar dolaresUno, Dolar dolaresDos)
        {

        }

        public static Dolar operator -(Dolar dolar, Euro euros)
        {

        }

        public static Dolar operator -(Dolar dolar, Pesos pesos)
        {

        }

        public static Dolar operator +(Dolar dolar, Euro euros)
        {

        }

        public static Dolar operator +(Dolar dolar, Pesos pesos)
        {

        }
    }
}
}
