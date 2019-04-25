using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil autoUno = new Automovil(4, 4, Colores.Azul, 6, 5);
            Automovil autoDos = new Automovil(2, 2, Colores.Blanco, 5, 2);
            Automovil autoTres = new Automovil(4, 4, Colores.Rojo, 6, 3);
            Camion camioncito = new Camion(4, 2, Colores.Gris, 5, 30000);
            Moto laMotitoDeCarlitos = new Moto(2, 0, Colores.Blanco, 6, 110);
            
            

        }
    }
}
