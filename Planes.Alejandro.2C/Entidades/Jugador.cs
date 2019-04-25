using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        #region Propiedades

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        #endregion

        #region Métodos

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendLine(base.Nombre.ToString());
            datos.AppendLine(base.Apellido.ToString());
            datos.AppendLine(base.Edad.ToString());
            datos.AppendLine(base.Dni.ToString());
            datos.AppendLine(this.Peso.ToString());
            datos.AppendLine(this.Altura.ToString());
            datos.AppendLine(this.Posicion.ToString());

            return datos.ToString();
        }

        /*
         ValidarEstadoFisico deberá validar que el índice de masa corporal se encuentre en el rango de 18.5 y
        25 inclusive. Para calcularlo, utilizar la siguiente fórmula:
        IMC = peso / altura^2
        */
        public override bool ValidarAptitud()
        {
            if(this.ValidarEstadoFisico() && this.Edad < 40)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarEstadoFisico()
        {
            double IMC = this.Peso / (this.Altura * this.Altura);

            if (IMC > 18.5 && IMC <= 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion


    }
}
