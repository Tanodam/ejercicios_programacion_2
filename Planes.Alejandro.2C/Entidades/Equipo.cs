using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico = null;
        private List<Jugador> jugadores;
        private string nombre;

        #region Propiedades

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value != null && value.ValidarAptitud())
                {
                    this.DirectorTecnico = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        #endregion

        #region Métodos

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool ValidarEquipo(Equipo equipo)
        {
            int arquero = 0;
            int defensor = 0;
            int central = 0;
            int delantero = 0;

            //Corregir lo del DT
            foreach (Jugador jugador in equipo.jugadores)
            {
                switch(jugador.Posicion)
                {
                    case Posicion.Arquero :
                        arquero++;
                        break;
                    case Posicion.Defensor :
                        defensor++;
                        break;
                    case Posicion.Central :
                        central++;
                        break;
                    case Posicion.Delantero :
                        delantero++;
                        break;
                }
            }

            if(arquero == 1 && defensor > 1 && central > 1 && delantero > 1 && 
                equipo.jugadores.Count == Equipo.cantidadMaximaJugadores && equipo.directorTecnico != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        #endregion

        #region Operadores

        public static explicit operator string(Equipo equipo)
        {
            StringBuilder datos = new StringBuilder("");

            if (equipo.directorTecnico == null)
            {
                datos.AppendLine("Sin DT asignado");
            }
            else
            {
                datos.AppendLine(equipo.directorTecnico.Mostrar());
            }

            //Corregir lo del DT
            foreach(Jugador jugador in equipo.jugadores)
            {
                if(jugador != null)
                {
                    datos.AppendLine(jugador.Mostrar());
                }
            }
            return datos.ToString();
        }

        public static bool operator !=(Equipo equipo, Jugador jugador)
        {
            return !(equipo == jugador);
        }

        public static bool operator ==(Equipo equipo, Jugador jugador)
        {
            return equipo.jugadores.Contains(jugador);
        }

        public static Equipo operator +(Equipo equipo, Jugador jugador)
        {
            if(equipo != jugador && equipo.jugadores.Count < Equipo.cantidadMaximaJugadores &&
                jugador.ValidarAptitud())
            {
                equipo.jugadores.Add(jugador);
                return equipo;
            }
            else
            {
                return equipo;
            }
        }

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
            return Tuple.Create(cantidadMaximaJugadores, directorTecnico, jugadores, nombre).GetHashCode();
        }

        #endregion
    }
}
