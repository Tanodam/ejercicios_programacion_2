using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        #region Propiedades

        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                if(value > 21 && value < 90)
                {
                    this.añosExperiencia = value;
                }
                else
                {
                    this.añosExperiencia = 0;
                }
            }
        }
        #endregion

        #region Métodos

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia)
        : base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendLine(base.Nombre.ToString().ToString());
            datos.AppendLine(base.Apellido.ToString());
            datos.AppendLine(base.Edad.ToString());
            datos.AppendLine(base.Dni.ToString());
            datos.AppendLine(this.AñosExperiencia.ToString());

            return datos.ToString();
        }

        public override bool ValidarAptitud()
        {
            if(base.Edad > 65 && this.AñosExperiencia > 2)
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
