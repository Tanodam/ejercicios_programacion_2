using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string apellido;
        protected int dni;
        protected int edad;
        protected string nombre;

        #region Propiedades

        public string Apellido
        {
            get;
        }

        public int Dni
        {
            get;
        }

        public int Edad
        {
            get;
        }

        public string Nombre
        {
            get;
        }

        #endregion

        #region Métodos

        public abstract string Mostrar();

        public Persona(string nombre ,string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public abstract bool ValidarAptitud();
        

        #endregion

    }
}
