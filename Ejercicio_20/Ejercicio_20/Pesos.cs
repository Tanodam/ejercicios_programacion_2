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
        float cotizRespectoDolar;

        public Pesos()
        {

        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion): this(cantidad)
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
        public static explicit operator Dolar(Pesos pesos)
        {

        }

        public static explicit operator Euro(Pesos pesos)
        {

        }

        public static implicit operator Pesos(double dolar)
        {

        }

        public static bool operator !=(Pesos pesos,Dolar dolar)
        {

        }

        public static bool operator !=(Pesos pesos, Euro euros)
        {

        }

        public static bool operator !=(Pesos pesosUno, Pesos pesosDos)
        {

        }

        public static bool operator ==(Pesos pesos, Dolar dolar)
        {

        }

        public static bool operator ==(Pesos pesos, Euro euros)
        {

        }

        public static bool operator ==(Pesos pesosUno, Pesos pesosDos)
        {

        }

        public static Pesos operator -(Pesos pesos, Dolar dolar)
        {

        }

        public static Pesos operator -(Pesos pesos, Euro euros)
        {

        }

        public static Pesos operator +(Pesos pesos, Dolar dolar)
        {

        }

        public static Pesos operator +(Pesos pesos, Euro euros)
        {

        }



    }
}
