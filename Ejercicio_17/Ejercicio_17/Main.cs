using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseBoligrafo;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);
            String dibujoAzul;
            String dibujoRojo;

            Console.Write("\nEl nivel de tinta del boligrafo azul es: " + boligrafoAzul.GetTinta());
            Console.Write("\nEl nivel de tinta del boligrafo rojo es: " + boligrafoRojo.GetTinta());

            Console.Write("\nEl color de tinta del boligrafo azul es: " + boligrafoRojo.GetColor());
            Console.Write("\nEl color de tinta del boligrafo rojo es: " + boligrafoRojo.GetColor());

            boligrafoAzul.Pintar(10, out dibujoAzul);
            boligrafoRojo.Pintar(5, out dibujoRojo);
            Console.ForegroundColor = boligrafoAzul.GetColor();
            Console.Write("\nEl consumo de tinta al dibujar fue >> " + dibujoAzul);
            Console.ForegroundColor = boligrafoRojo.GetColor();
            Console.Write("\nEl consumo de tinta al dibujar fue >> " + dibujoRojo);
            Console.ResetColor();
            Console.Write("\nEl nivel de tinta del boligrafo azul es: " + boligrafoAzul.GetTinta());
            Console.Write("\nEl nivel de tinta del boligrafo rojo es: " + boligrafoRojo.GetTinta());
            Console.ReadKey();
        }
    }
}
