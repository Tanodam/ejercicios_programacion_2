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

        public void CalcularFinal()
        {
            notaFinal = -1;
            Random numeroRandom = new Random();

            if (nota1 > 4 && nota2 > 4)
            {
                notaFinal = numeroRandom.Next();
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
            if(notaFinal != -1)
            {
                return String.Concat(nombre, apellido, legajo, nota1, nota2, notaFinal);
            }
            else
            {
                return String.Concat(nombre, apellido, legajo, nota1, nota2, "Alumno desaprobado!");
            } 
        }

        static void Main(string[] args)
        {
            Alumno pepito = new Alumno();
            Alumno juancito = new Alumno();
            Alumno manuelita = new Alumno();

            pepito.Estudiar(4, 5);

        }
    }
}
