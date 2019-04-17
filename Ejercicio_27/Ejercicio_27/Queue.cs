using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    public class Queue
    {
        public static void TestQueue()
        {
            Queue<int> numeros = new Queue<int>();
            int[] auxArray;
            Random numeroRandom = new Random();

            Console.Write("\n\n--TEST QUEUE--");
            for (int i = 0; i < 20; i++) //Se cargan numeros aleatorios negativos y positivos
            {
                numeros.Enqueue(numeroRandom.Next(-100, 100));
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
                numeros.Enqueue(aux);
                if (numeros.Last() < 0)
                {
                    Console.Write("\n{0}", numeros.Last());
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
