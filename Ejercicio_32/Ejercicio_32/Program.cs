using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugadorUno = new Jugador(33444555, "Pepito Salvatierra", 6, 15);
            Jugador jugadorDos = new Jugador(11123123, "Juanito De La Piedra");
            Jugador jugadorTres = new Jugador(44321321, "Manolo Gomez", 4, 16);
            Jugador jugadorCuatro = new Jugador(15666555, "Luciano Forza");
            Jugador jugadorCinco = new Jugador(33444555, "Salvador Concha", 8,22);
            Equipo equipo = new Equipo(8, "Los Pijudos Sport");

            if(equipo + jugadorUno)
            {
                Console.Write("\n\nSE AGREGÓ JUGADOR. {0}", jugadorUno.MostrarDatos());
            }

            if (equipo + jugadorDos)
            {
                Console.Write("\n\nSE AGREGÓ JUGADOR. {0}", jugadorDos.MostrarDatos());
            }
            
            if (equipo + jugadorTres)
            {
                Console.Write("\n\nSE AGREGÓ JUGADOR. {0}", jugadorTres.MostrarDatos());
            }

            if (equipo + jugadorCuatro)
            {
                Console.Write("\n\nSE AGREGÓ JUGADOR. {0}", jugadorCuatro.MostrarDatos());
            }

            if (equipo + jugadorCinco)
            {
                Console.Write("\n\nSE AGREGÓ JUGADOR. {0}", jugadorCinco.MostrarDatos());
            }
            Console.ReadKey();
        }
    }
}
