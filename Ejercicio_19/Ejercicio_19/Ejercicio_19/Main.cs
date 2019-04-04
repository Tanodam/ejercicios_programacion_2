using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Sumador sumadorUno = new Sumador(4);
            Sumador sumadorDos = new Sumador(1);

            Console.Write(sumadorUno.Sumar(1000, 1500));
            Console.Write(sumadorUno.Sumar("\nRaton", "cito\n"));

            Console.Write(sumadorDos.Sumar(1000, 1500));
            Console.Write(sumadorDos.Sumar("\nMotor", "cito\n"));

            Console.Write("\nLa suma total de ambos sumadores es: {0}", sumadorUno + sumadorDos);
            Console.Write("\nLas sumas son iguales?!: " + (sumadorUno | sumadorDos));

            Console.ReadKey();
        }
    }
}
