using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        #region Constructores

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {}

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : base(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        #endregion

        #region Propiedades

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public float PromedioGoles
        {
            get
            {
                if (this.partidosJugados > 0 && this.totalGoles > 0)
                {
                    return ((float)TotalGoles / (float)PartidosJugados); //Es necesario castear a float antes de dividir
                }
                else
                {
                    return 0;
                }
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                this.totalGoles = value;
            }
        }

        #endregion

        #region Métodos

        public new string MostrarDatos()
        {
            string datos = "";

            datos += base.MostrarDatos();
            datos += "\nPartidos jugados: " + this.PartidosJugados.ToString();
            datos += "\nPromedio de goles: " + this.PromedioGoles.ToString();
            datos += "\nTotal goles: " + this.TotalGoles.ToString();

            return datos;
        }

        #endregion

        #region Operadores

        public static bool operator ==(Jugador jugadorUno, Jugador jugadorDos)
        {
            return jugadorUno.Dni == jugadorDos.Dni ? true : false;
        }
        public static bool operator !=(Jugador jugadorUno, Jugador jugadorDos)
        {
            return !(jugadorUno == jugadorDos);
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
            return Tuple.Create(dni, nombre, partidosJugados, totalGoles).GetHashCode();
        }
    }
}