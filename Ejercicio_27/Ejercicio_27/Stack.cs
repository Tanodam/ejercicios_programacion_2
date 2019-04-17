using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//. Realizar el ejercicio anterior pero esta vez con las siguientes colecciones: Pilas, Colas y Listas.

namespace Ejercicio_27
{
    public class Stack
    {
        public static void TestStack()
        {
            Stack<int> numeros = new Stack<int>();
            int[] auxArray;
            Random numeroRandom = new Random();

            Console.Write("\n\n--TEST STACK--");
            for (int i = 0; i < 20; i++) //Se cargan numeros aleatorios negativos y positivos
            {
                numeros.Push(numeroRandom.Next(-100, 100));
            }

            Console.Write("\n\nNumeros sin ordenar");
            foreach (int aux in numeros) //Se muestra el array tal como fue ingresado
            {
                Console.Write("\n{0}", aux);
            }

            auxArray = numeros.ToArray();
            Array.Sort(auxArray);
            numeros.Clear();
            Console.Write("\n\nNumeros negativos de forma ascendente");
            foreach (int aux in auxArray) //Se muestran los numeros negativos de forma ascendente
            {
                numeros.Push(aux);
                if (numeros.Peek() < 0)
                {
                    Console.Write("\n{0}", numeros.Peek());
                }
            }

            numeros.Reverse();
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
