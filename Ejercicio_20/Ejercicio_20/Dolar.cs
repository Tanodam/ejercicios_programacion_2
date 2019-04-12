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
            return new Euro(dolares.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar dolares)
        {
            return new Pesos(dolares.GetCantidad() / Pesos.GetCotizacion());
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        public static bool operator !=(Dolar dolares, Euro euros)
        {
            return !(dolares == euros);
        }

        public static bool operator !=(Dolar dolares, Pesos pesos)
        {
            return !(dolares == pesos);
        }

        public static bool operator !=(Dolar dolaresUno, Dolar dolaresDos)
        {
            return !(dolaresUno == dolaresDos);
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
            return new Dolar(dolar.GetCantidad() - ((Dolar)euros).GetCantidad());
        }

        public static Dolar operator -(Dolar dolar, Pesos pesos)
        {
            return new Dolar(dolar.GetCantidad() - ((Dolar)pesos).GetCantidad());
        }

        public static Dolar operator +(Dolar dolar, Euro euros)
        {
            return new Dolar(dolar.GetCantidad() + ((Dolar)euros).GetCantidad());
        }

        public static Dolar operator +(Dolar dolar, Pesos pesos)
        {
            return new Dolar(dolar.GetCantidad() + ((Dolar)pesos).GetCantidad());
        }
    }
}

