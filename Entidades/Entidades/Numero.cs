using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double numero;

        public Numero(): this(0)
        {
        }
        public Numero(string strNumero): this(double.Parse(strNumero))
        {
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public string BinarioDecimal(string binario)
        {
            char[] arrayBinario;
            double numeroDecimal = 0;

            arrayBinario = binario.ToCharArray();
            Array.Reverse(arrayBinario);

            for (int i = 0; i < arrayBinario.Length; i++)
            {
                if (arrayBinario[i] == '1')
                {
                    numeroDecimal += (int)Math.Pow(2, i);
                }
            }
            return Convert.ToString(numeroDecimal);
        }
        public string DecimalBinario(string numeroDecimal)
        {
            return DecimalBinario(double.Parse(numeroDecimal));
        }
        public string DecimalBinario(double numeroDecimal)
        {
            String resultado = "";

            if (numeroDecimal > 0)
            {
                while (numeroDecimal > 0)
                {
                    if (numeroDecimal % 2 == 0) //Verifica el resto de la división
                    {
                        resultado = "0" + resultado;//Concatena el resto de la división
                    }
                    else
                    {
                        resultado = "1" + resultado;
                    }
                    numeroDecimal = (int)(numeroDecimal / 2); //Sigue dividiendo
                }
            }
            else
            {
                if (numeroDecimal == 0)
                {
                    resultado += "Valor inválido.";
                }
            }
            return resultado;
        }
        public double ValidarNumero(string strNumero)
        {
            char[] arrayNumero = strNumero.ToArray();//Desarmo el string para recorrerlo
            string resultado = "";

            for(int i = 0;i <= arrayNumero.Length;i++)
            {
                if (Convert.ToByte(arrayNumero[i]) >= 0 && Convert.ToByte(arrayNumero[i]) <= 9)
                {
                    resultado += arrayNumero[i];
                    continue;
                }
                else
                {
                    return 0;
                }
            }
            return Convert.ToDouble(resultado);
        }

        public string SetNumero //Propiedad de solo lectura
        {
            set
            {
                numero = ValidarNumero(value);
            }
        }

        public static double operator -(Numero primerNumero, Numero segundoNumero)
        {
            return primerNumero.numero - segundoNumero.numero;
        }
        public static double operator +(Numero primerNumero, Numero segundoNumero)
        {
            return primerNumero.numero + segundoNumero.numero;
        }
        public static double operator *(Numero primerNumero, Numero segundoNumero)
        {
            return primerNumero.numero * segundoNumero.numero;
        }
        public static double operator /(Numero primerNumero, Numero segundoNumero)
        {
            if(segundoNumero.numero == 0)
            {
                return double.MinValue;
            }
            return primerNumero.numero / segundoNumero.numero;
        }
    }
}

