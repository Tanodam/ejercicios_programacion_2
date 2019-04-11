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
        static float cotizRespectoDolar;

        public Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion) : this(cantidad)
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
            if (dolares.GetCantidad() == (euros.GetCantidad() / cotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Dolar dolares, Pesos pesos)
        {
            if (dolares.GetCantidad() == (pesos.GetCantidad() / cotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Dolar dolaresUno, Dolar dolaresDos)
        {
            if (dolaresUno.GetCantidad() == dolaresDos.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Dolar operator -(Dolar dolar, Euro euros)
        {
            return dolar.GetCantidad() - euros.GetCantidad() / cotizRespectoDolar;
        }

        public static Dolar operator -(Dolar dolar, Pesos pesos)
        {
            return dolar.GetCantidad() - pesos.GetCantidad() / cotizRespectoDolar;
        }

        public static Dolar operator +(Dolar dolar, Euro euros)
        {
            return dolar.GetCantidad() + euros.GetCantidad() / cotizRespectoDolar;
        }

        public static Dolar operator +(Dolar dolar, Pesos pesos)
        {
            return dolar.GetCantidad() + pesos.GetCantidad() / cotizRespectoDolar;
        }
    }
}

