using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Pesos misPesos = new Pesos(2000);
            Euro misEuros = new Euro(100);
            Dolar misDolares = new Dolar(300);
            
            Console.Write("Tengo {0} Pesos\nTengo {1} Pesos\nTengo {2} Pesos", misPesos.GetCantidad(), misEuros, misPesos);
            Console.ReadKey();

        }
    }
}
