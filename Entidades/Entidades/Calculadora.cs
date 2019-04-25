using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Entidades
{
    class Calculadora
    {
        public static double Operar(Numero primerNumero, Numero segundoNumero, string operador)
        {
            string operacion;
            double resultado = 0;

            operacion = ValidarOperador(operador);

            switch(operacion)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "*":
                    resultado = primerNumero * segundoNumero;
                    break;
                case "/":
                    resultado = primerNumero / segundoNumero;
                    break;
            }
            return resultado;
        }
        private static string ValidarOperador(string operador)
        {
            if(operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }
            else
            {
                return "+";
            }
        }
    }

}