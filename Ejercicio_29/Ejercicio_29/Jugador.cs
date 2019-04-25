using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

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

        public float GetPromedioGoles()
        {
            if(this.partidosJugados > 0 && this.totalGoles > 0)
            {
                promedioGoles = ((float)totalGoles / (float)partidosJugados); //Es necesario castear a float antes de dividir
            }
            return promedioGoles;
        }

        public string MostrarDatos()
        {
            string datos = "";

            datos += "\n\nNombre: " + this.nombre;
            datos += "\nDNI: " + this.dni.ToString();
            datos += "\nPartidos jugados: " + this.partidosJugados.ToString();
            datos += "\nPromedio de goles: " + this.GetPromedioGoles().ToString();
            datos += "\nTotal goles: " + this.totalGoles.ToString();

            return datos;
        }

        public static bool operator ==(Jugador jugadorUno, Jugador jugadorDos)
        {
            return jugadorUno.dni == jugadorDos.dni ? true : false;
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
            return Tuple.Create(dni, nombre, partidosJugados, promedioGoles, totalGoles).GetHashCode();
        }
    }
}
