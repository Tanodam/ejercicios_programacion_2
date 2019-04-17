using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    public class List
    {
        public static void TestList()
        {
            List<int> numeros = new List<int>();
            Random numeroRandom = new Random();

            Console.Write("\n\n--TEST LIST--");
            for (int i = 0; i < 20; i++) //Se cargan numeros aleatorios negativos y positivos
            {
                numeros.Add(numeroRandom.Next(-100, 100));
            }

            Console.Write("\n\nNumeros sin ordenar");
            foreach (int aux in numeros) //Se muestra el array tal como fue ingresado
            {
                Console.Write("\n{0}", aux);
            }

            numeros.Sort();
            Console.Write("\n\nNumeros negativos de forma ascendente");
            foreach (int aux in numeros) //Se muestran los numeros negativos de forma ascendente
            {
                if (aux < 0)
                {
                    Console.Write("\n{0}", aux);
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
