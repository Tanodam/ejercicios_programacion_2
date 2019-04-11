using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        double cantidad;
        static float cotizRespectoDolar;

        public Pesos()
        {
            cotizRespectoDolar = 38.33f;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion): this(cantidad)
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
        public static explicit operator Dolar(Pesos pesos)
        {
            return new Dolar(pesos.GetCantidad() / cotizRespectoDolar);
        }

        public static explicit operator Euro(Pesos pesos)
        {
            return new Euro(pesos.GetCantidad() * Pesos.GetCotizacion() / Euro.GetCotizacion());
        }

        public static implicit operator Pesos(double cantidad)
        {
            return new Pesos(cantidad); 
        }

        public static bool operator !=(Pesos pesos,Dolar dolar)
        {
            return !(pesos == dolar);
        }

        public static bool operator !=(Pesos pesos, Euro euros)
        {
            return !(pesos == euros);
        }

        public static bool operator !=(Pesos pesosUno, Pesos pesosDos)
        {
            return !(pesosUno == pesosDos);
        }

        public static bool operator ==(Pesos pesos, Dolar dolar)
        {
            if (pesos.GetCantidad() == (dolar.GetCantidad() / cotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Pesos pesos, Euro euros)
        {
            if (pesos.GetCantidad() == (euros.GetCantidad() / cotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Pesos pesosUno, Pesos pesosDos)
        {
            if(pesosUno.GetCantidad() == pesosDos.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Pesos operator -(Pesos pesos, Dolar dolar)
        {
            return pesos.GetCantidad() - dolar.GetCantidad() / cotizRespectoDolar;
        }

        public static Pesos operator -(Pesos pesos, Euro euros)
        {
            return pesos.GetCantidad() - euros.GetCantidad() / cotizRespectoDolar;
        }

        public static Pesos operator +(Pesos pesos, Dolar dolar)
        {
            return new Pesos(pesos.GetCantidad() + ((Pesos)dolar).GetCantidad());
        }

        public static Pesos operator +(Pesos pesos, Euro euros)
        {
            return new Pesos(pesos.GetCantidad() + ((Pesos)euros).GetCantidad());
        }
    }
}
