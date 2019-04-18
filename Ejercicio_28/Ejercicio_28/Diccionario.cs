using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Utilizar Diccionarios (Dictionary<string, int>) para realizar un contador de palabras, recorriendo el
    texto palabra por palabra se deberá lograr que si se trata de una nueva palabra, se la agregará al
    diccionario e inicializar su contador en 1, caso contrario se deberá incrementar dicho contador.
    Ordenar los resultados de forma descendente por cantidad de apariciones de cada palabra.
    Informar mediante un MessageBox el TOP 3 de palabras con más apariciones. 
 */
namespace Ejercicio_28
{
    public class Diccionario
    {
        public static Dictionary<string, int> diccionario;

        static Diccionario()
        {
            diccionario = new Dictionary<string, int>();
        }

        public static void SetValue(string palabra)
        {
            if(diccionario.ContainsKey(palabra))
            {
                diccionario[palabra] += 1; 
            }
            else
            {
               diccionario.Add(palabra,1);
            }
        }
    }
}
