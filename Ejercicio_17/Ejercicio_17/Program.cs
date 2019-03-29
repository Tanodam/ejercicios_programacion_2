using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {

        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(int gasto,out string dibujo)
        {
            if(gasto < this.tinta)
            {
                 this.SetTinta((short)-gasto);

            
                String.dibujo = 
            }
            dibujo = "dibujo";
            return true;
        }
        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }
        private void SetTinta(short tinta)
        {
            if((this.tinta + tinta) < cantidadTintaMaxima || (this.tinta + tinta) > 0)
            {
                this.tinta = tinta;
            }   
        }


        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

        }
    }
}
