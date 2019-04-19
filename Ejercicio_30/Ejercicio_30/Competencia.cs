using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public static bool operator -(Competencia competencia, AutoF1 auto)
        {
            if (competencia == auto)
            {
                competencia.competidores.Remove(auto);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator +(Competencia competencia, AutoF1 auto)
        {  
            if(competencia != auto && competencia.competidores.Count < competencia.cantidadCompetidores)
            {
                auto.SetEnCompetencia(true);
                auto.SetVueltasRestantes(competencia.cantidadVueltas);
                auto.SetCantidadCombustible();
                competencia.competidores.Add(auto);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Competencia competencia, AutoF1 auto)
        {
            bool returnValue = false;

            foreach (AutoF1 auxiliar in competencia.competidores)
            {
                if (auxiliar == auto)
                {
                    returnValue = true;
                    break;
                }
            }
            return returnValue;
        }
        public static bool operator !=(Competencia competencia, AutoF1 auto)
        {
            return !(competencia == auto);
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
            return Tuple.Create(cantidadCompetidores, cantidadVueltas, competidores).GetHashCode();
        }

    }
}
