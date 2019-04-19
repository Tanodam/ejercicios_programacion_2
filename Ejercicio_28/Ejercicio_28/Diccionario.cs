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

        public static string GetValues(int cantidad)
        {
            List<KeyValuePair<string,int>> listaValores= diccionario.ToList();
            String values = "";

            listaValores.Sort(Compare);
            listaValores.Reverse();

            for (int i = 0;i < cantidad;i++)
            {
                values += "\n"+ listaValores[i].ToString();
            }
            return values;
        }

        static int Compare(KeyValuePair<string, int> primerElemento, KeyValuePair<string, int> segundoElemento)
        {
            int returnValue = 0;

            if(primerElemento.Value > segundoElemento.Value)
            {
                returnValue = 1;
            }
            else if(primerElemento.Value < segundoElemento.Value)
            {
                returnValue = -1;
            }
            else
            {
                returnValue = 0;
            }
            return returnValue;
        }
    }
}
