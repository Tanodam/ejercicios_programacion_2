using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    /*
    Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
    string DecimalBinario(double). Convierte un número de decimal a binario.
    double BinarioDecimal(string). Convierte un número binario a decimal.
    */
    class Conversor
    {

        public static string DecimalBinario(double number)
        {
            double result;
            int rest;
            String binaryArray;

            do
            {
                result = number / 2; 
                rest = (int)(number % 2);
                binaryArray = rest.ToString();
                number = result;

            } while (result == 3 || result == 2);
      
            binaryArray.Reverse();
            return binaryArray;
        }

        public static double BinarioDecimal(string numeroBinario)
        {
            int limite;
            double numeroDecimal = 0;
            int potencia = 1; ;
            int auxiliar;

            numeroBinario.Reverse();

            for(limite = numeroBinario.Length; limite >= 0;limite--)
            {
                int.TryParse(numeroBinario, out auxiliar);
                numeroDecimal += Conversor.potencia(auxiliar,potencia);
                potencia *= 2;
            }
            return numeroDecimal;
        }

        public static double potencia(int numero, int potencia)
        {
            double resultado = 0;

            while(potencia != 0)
            {
                resultado = numero * numero;
                potencia--;
            }
            return resultado;
        }

        static void Main(string[] args)
        {
            string binario;
            double numeroDecimal;

            binario = Conversor.DecimalBinario(10);
            numeroDecimal = Conversor.BinarioDecimal("1010");

            Console.Write("{0}\n{1}", binario,numeroDecimal);
            Console.ReadKey();
        }
    }
}
