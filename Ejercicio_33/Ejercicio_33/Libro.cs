using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                if(i < paginas.Count)
                {
                    return paginas[i];
                }
                else
                {
                    return "";
                }

            }
            set
            {
                if(i == paginas.Count)
                {
                    paginas[i] = value;
                }
            }

        }
    }
}
