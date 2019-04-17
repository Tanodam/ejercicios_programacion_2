using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de
    cero de forma aleatoria utilizando la clase Random.
    a. Mostrar el vector tal como fue ingresado
    b. Luego mostrar los positivos ordenados en forma decreciente.
    c. Por último, mostrar los negativos ordenados en forma creciente
*/
namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            Random numeroRandom = new Random();

            for(int i = 0; i < numeros.Length; i++) //Se cargan numeros aleatorios negativos y positivos
            {
                numeros[i] = numeroRandom.Next(-100, 100);
            }

            Console.Write("\n\nNumeros sin ordenar");
            foreach (int aux in numeros) //Se muestra el array tal como fue ingresado
            {
                 Console.Write("\n{0}",aux);
            }


            Array.Sort(numeros);
            Console.Write("\n\nNumeros negativos de forma ascendente");
            foreach (int aux in numeros) //Se muestran los numeros negativos de forma ascendente
            {
                if(aux < 0)
                {
                    Console.Write("\n{0}", aux);
                }
            }

            Array.Reverse(numeros);
            Console.Write("\n\nNumeros positivos de forma descendente");
            foreach (int aux in numeros) //Se muestran los numeros positivos de forma descendentes
            {
                if (aux > 0)
                {
                    Console.Write("\n{0}", aux);
                }
            }
            Console.ReadKey();
        }
    }
}
