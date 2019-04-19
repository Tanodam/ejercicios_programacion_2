using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        #region Constructores

        private Jugador()
        {
            this.totalGoles = 0;
            this.partidosJugados = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        #endregion

        #region Propiedades

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value; //Validar DNI
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value; //Validar Nombre
            }
        }

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
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
        }

        #endregion


        public string MostrarDatos()
        {
            string datos = "";

            datos += "\n\nNombre: " + this.Nombre;
            datos += "\nDNI: " + this.Dni.ToString();
            datos += "\nPartidos jugados: " + this.PartidosJugados.ToString();
            datos += "\nPromedio de goles: " + this.PromedioGoles.ToString();
            datos += "\nTotal goles: " + this.TotalGoles.ToString();

            return datos;
        }

        public static bool operator ==(Jugador jugadorUno, Jugador jugadorDos)
        {
            return jugadorUno.Dni == jugadorDos.Dni ? true : false;
        }
        public static bool operator !=(Jugador jugadorUno, Jugador jugadorDos)
        {
            return !(jugadorUno == jugadorDos);
        }

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
