using System;
using System.Collections.Generic;

namespace Ejercicio_08
{
    public class Company
    {
        LinkedList<Employees> employees;

        public Boolean add(Employees newEmployee)//TESTEAR
        {
            employees.AddFirst(newEmployee);//Corregir
            return true;
        }

        public void generateData()
        {
            int totalDiscounts = 0;
            int totalSalaries = 0;

            foreach (Employees auxiliar in employees)
            {
                Console.Write(auxiliar.getName(),
                                auxiliar.getYears(),
                                auxiliar.getHoursValue(),
                                auxiliar.totalSalary());

                totalDiscounts += auxiliar.discount();
                totalSalaries += auxiliar.netSalary();
            }
            Console.Write(totalDiscounts.ToString(), totalSalaries.ToString());
        }
    }
}

