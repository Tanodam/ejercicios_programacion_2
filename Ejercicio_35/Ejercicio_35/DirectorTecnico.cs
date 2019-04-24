using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        #region Constructores

        public DirectorTecnico(int dni, string nombre) : base(dni, nombre)
        {}

        public DirectorTecnico(int dni, string nombre, DateTime fechaNacimiento) : base(dni, nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        #endregion

        #region Propiedades

        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;
            }
        }

        #endregion

        #region Métodos

        public new string MostrarDatos()
        {
            string datos = "";

            datos += this.MostrarDatos();
            datos += "\nFecha de nacimiento: " + this.fechaNacimiento.ToString();

            return datos;
        }


        #endregion

        #region Operadores

        public static bool operator ==(DirectorTecnico dtUno, DirectorTecnico dtDos)
        {
            return dtUno.Dni == dtDos.Dni ? true : false;
        }
        public static bool operator !=(DirectorTecnico dtUno, DirectorTecnico dtDos)
        {
            return !(dtUno == dtDos);
        }

        #endregion

        //
        //OVERRIDE EQUALS
        //
        public override bool Equals(object obj)
        {
            if (obj != null || this.GetType() != obj.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Tuple.Create(dni, nombre, fechaNacimiento).GetHashCode();
        }
    }
}