using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            libro[0] = "Pagina Uno";
            libro[1] = "Pagina Dos";
            libro[2] = "Pagina Tres";
            libro[3] = "Pagina Cuatro";
            libro[4] = "Pagina Cinco";

            for (int i = 0; i < 6; i++)
            {
                Console.Write(libro[i]);
            }
            Console.ReadKey();
        }
    }
}
