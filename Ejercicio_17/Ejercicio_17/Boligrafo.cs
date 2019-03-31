using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBoligrafo
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.SetTinta(tinta);
            this.SetColor(color);
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
            bool returnValue = false;
            dibujo = "";

            if (this.tinta > 0)
            {
                for (int i = 0; this.tinta > 0 && i < gasto;i++)
                {
                    dibujo += "*";
                }
                gasto = this.tinta - gasto;
                this.SetTinta((short)gasto);
                returnValue = true;
            }
            return returnValue;
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
        private void SetColor(ConsoleColor color)
        {
            this.color = color;
        }

       
    }
}
