using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void primos(int numero)
        {
            for (int i = 0; i < numero; i++)
            {
                if (i > 3 && (i % 2 == 0 || i % 3 == 0)) 
                {
                    continue;
                }
                Console.Write(i + "\n");
            }
        }

        static void numeroPerfecto()
        {
            int acumulador = 0;
            int contador = 0;
            int numero;

            for (numero = 1; contador != 4; numero++)
            {
                for (int j = 1; j < numero; j++)
                {
                    if(numero % j == 0)
                    {
                        acumulador += j;
                      //  Console.Write("Numero: "+numero+" Cociente: "+j+"\n");
                    }
                }
                
                if (acumulador == numero)
                {
                    Console.Write(numero + " es un numero perfecto\n");
                    contador++;
                   Console.Write(contador+"\n");
                }
                acumulador = 0;
            }
        }

        static void cuadrado(int numero)
        {
            double resultado = 0;

            resultado = Math.Pow(numero, 2);
            Console.Write("{0}", "El cuadrado de " + numero + " es: " + resultado + "\n");
        }

        static void cubo(int numero)
        {
            double resultado = 0;

            resultado = Math.Pow(numero, 3);
            Console.Write("{0}", "El cubo de " + numero + " es: " + resultado + "\n");
        }


        static void Main(string[] args)
        {
           /* int numero = 0;
            int numeroMaximo = int.MaxValue;
            int numeroMinimo = int.MinValue;
            int total = 0;
            int promedio;
           
            int i;

            Console.Title = "Ejercicio_01";
            Console.Write("Ingrese 5 numeros por consola\n");

            for (i = 0; i < 5; i++)
            {
                numero = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    numeroMinimo = numero;
                    numeroMaximo = numero;
                }
                else if (numero < numeroMinimo)
                {
                    numeroMinimo = numero;
                }
                else if (numero > numeroMaximo)
                {
                    numeroMaximo = numero;
                }
                total += numero;
            }
            promedio = total / i;

            Console.Write("{0}{1}{2}", "El menor valor es:" + numeroMinimo + "\n",
                            "El maximo valor es:" + numeroMaximo + "\n", "El promedio es:" + promedio + "\n");
            Console.ReadKey();

            Program.cuadrado(numero);
            Program.cubo(numero);
            Console.ReadKey();
            Program.primos(20);*/
            Program.numeroPerfecto();
            Console.ReadKey();


            //federicordavila@gmail.com
            //github: fededavila1984
        }
    }
}
