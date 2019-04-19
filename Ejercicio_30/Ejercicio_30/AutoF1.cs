using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero,string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            //Parametros inicializados
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            String datosAuto = "";

            datosAuto += "\nNumero: " + this.numero.ToString();
            datosAuto += "\nEscuderia: " + this.escuderia.ToString();
            datosAuto += "\nEn Competencia: " + this.GetEnCompetencia().ToString();
            datosAuto += "\nCantidad de combustible: " + this.GetCantidadCombustible().ToString();
            datosAuto += "\nVueltas restantes: " + this.GetVueltasRestantes().ToString();

            return datosAuto;
          }

        public static bool operator !=(AutoF1 autoUno, AutoF1 autoDos)
        {
            return !(autoUno == autoDos);
        }
        public static bool operator ==(AutoF1 autoUno, AutoF1 autoDos)
        {
            if(autoUno.numero == autoDos.numero && autoUno.escuderia == autoDos.escuderia)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            return Tuple.Create(cantidadCombustible, enCompetencia, escuderia, numero, vueltasRestantes).GetHashCode();
        }

        #region Getters & Setters

        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public void SetCantidadCombustible()
        {
            Random numeroRandom = new Random();

            this.cantidadCombustible = (short)numeroRandom.Next(15,100);
        }

        public void SetEnCompetencia(bool value)
        {
            this.enCompetencia = value;
        }

        public void SetVueltasRestantes(short vueltas)
        {
            this.vueltasRestantes = vueltas;
        }

        #endregion
    }
}
