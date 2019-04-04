using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
	    private int cantidadSumas;

        public Sumador() : this(0)
        {

        }
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
     
        public long Sumar(long a,long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }
        public static long operator +(Sumador primerSumador,Sumador segundoSumador)
        {
            return (long)((int)primerSumador + (int)segundoSumador);
        }
        public static bool operator |(Sumador primerSumador, Sumador segundoSumador)
        {
            if((int)primerSumador == (int)segundoSumador)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
