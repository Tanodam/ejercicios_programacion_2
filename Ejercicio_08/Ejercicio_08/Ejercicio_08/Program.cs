using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    public class Programa
    {
        public static Boolean confirmacion()
        {
            string opcion;

            Console.Write("Desea continuar??\n");
            opcion = Console.ReadLine();

            if (opcion == "s" || opcion == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            string auxName;
            string auxHours;
            string auxYears;
            Company company = new Company();
            Employees employee;

            do
            {
                Console.Write("Enter employee data: \n");
                auxName = Console.ReadLine();
                auxHours = Console.ReadLine();
                auxYears = Console.ReadLine();

                employee = new Employees(auxHours, auxName, auxYears); // TESTEAR
                company.add(employee);

            } while (confirmacion());
        }
    }
}
