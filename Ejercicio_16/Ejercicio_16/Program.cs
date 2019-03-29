using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        string nombre;
        string apellido;
        int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }


        public void CalcularFinal()
        {
            notaFinal = -1;
            Random numeroRandom = new Random();

            if (nota1 > 4 && nota2 > 4)
            {
                notaFinal = numeroRandom.Next(1, 10);
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            if (notaFinal != -1)
            {
                return String.Concat("\nNombre: " + nombre,
                                     "\nApellido: " + apellido,
                                     "\nLegajo: " + legajo,
                                     "\nNota uno: " + nota1,
                                     "\nNota dos: " + nota2,
                                     "\nNota final: " + notaFinal);
            }
            else
            {
                return String.Concat("\nNombre: " + nombre,
                                     "\nApellido: " + apellido,
                                     "\nLegajo: " + legajo,
                                     "\nNota uno: " + nota1,
                                     "\nNota dos: " + nota2,
                                     "\nAlumno desaprobado!");
            }
        }

        static void Main(string[] args)
        {
            Alumno pepito = new Alumno("Pepito", "Salvapiedras", 123);
            Alumno juancito = new Alumno("Juancito", "Santillan", 124);
            Alumno manuelita = new Alumno("Manuelita", "Paredes", 125);

            pepito.Estudiar(4, 5);
            juancito.Estudiar(8, 5);
            manuelita.Estudiar(7, 5);

            pepito.CalcularFinal();
            juancito.CalcularFinal();
            manuelita.CalcularFinal();

            Console.Write("\n" + pepito.Mostrar());
            Console.Write("\n" + juancito.Mostrar());
            Console.Write("\n" + manuelita.Mostrar());
            Console.ReadKey();
        }
    }
}
