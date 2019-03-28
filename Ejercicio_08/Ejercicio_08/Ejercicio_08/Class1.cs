using System;

namespace Ejercicio_08
{
    public class Employees
    {
        int hoursValue;
        string name;
        int years;

        public Employees(string value, string auxName, string years)
        {
            int intHours;
            int intYears;

            Int32.TryParse(value, out intHours);
            Int32.TryParse(years, out intYears);

            this.setHoursValue(intHours);
            this.setName(auxName);
            this.setYears(intYears);
        }
        public int totalSalary() //Sueldo bruto
        {
            int monthHours = 24 * 30; // horas por dias
            int total = 0;

            total += hoursValue * monthHours;
            total += years * 150;
            return total;// PLATA
        }

        public int discount() //Descuento
        {
            int salary;
            int descuento;

            salary = this.totalSalary();
            descuento = (salary * 13) / 100;
            return descuento;
        }

        public int netSalary() //Sueldo neto
        {
            int netSalary;

            netSalary = totalSalary() - discount();
            return netSalary;
        }

        Boolean setHoursValue(int value) //Corregir
        {
            hoursValue = value;
            return true;
        }
        Boolean setName(string auxName)
        {
            this.name = auxName;
            return true;
        }
        Boolean setYears(int workedYears)
        {
            years = workedYears;
            return true;
        }
        public int getHoursValue()
        {
            return this.hoursValue;
        }
        public String getName()
        {
            return this.name;
        }
        public int getYears()
        {
            return this.years;
        }
    }
}

