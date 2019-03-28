using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que
posea la siguiente firma: bool Validar(int valor, int min, int max):
a. valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio
    */

namespace Ejercicio_11
{
    class Validacion
    {
        static bool Validar(int valor, int min, int max)
        {
            bool returnValue = false;

            if(valor > min && valor < max)
            {
                returnValue = true;
            }
            return returnValue;
        }

        static void Main(string[] args)
        {
            int contador = 0;
            int numero;
            int minimo = int.MinValue;
            int maximo = int.MaxValue;
            int promedio;
            int total = 0;

            do
            {
                Console.Write("Ingrese un numero: \n");
                numero = int.Parse(Console.ReadLine());
                if (Validar(numero, -100, 100))
                {
                    if(contador == 0)
                    {
                        minimo = numero;
                        maximo = numero;
                    }
                    else if(numero < minimo)
                    {
                        minimo = numero;
                    }
                    else if(numero > maximo)
                    {
                        maximo = numero;
                    }

                    total += numero;
                    contador++;
                }
            } while (contador < 10);

            promedio = total / contador;
            Console.Write("{0}{1}{2}",minimo+" ", maximo + " ", promedio);
            Console.ReadKey();
        }
    }
}
