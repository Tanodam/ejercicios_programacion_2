using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{

	public class Llamada
	{
	    public enum TipoLlamada
	    {
		    Local,
		    Provincial,
		    Todas,
	    }

		protected float duracion;
		protected string nroDestino;
		protected string nroOrigen;

		#region Propiedades

		public float Duracion
		{
			get
			{
				return this.duracion;
			}
		}

		public string NroDestino
		{
			get
			{
				return this.nroDestino;
			}
		}

		public string NroOrigen
		{
			get
			{
				return this.nroOrigen;
			}
		}

		#endregion

		#region Métodos

        public Llamada()
        { }

		public Llamada(float duracion, string destino, string origen)
		{
			this.duracion = duracion;
			this.nroDestino = destino;
			this.nroOrigen = origen;
		}

		public string Mostrar()
		{
			StringBuilder datos = new StringBuilder("");

			datos.Append(this.Duracion.ToString());
			datos.Append(this.nroDestino);
			datos.Append(this.nroOrigen);

			return datos.ToString();
		}

		public int OrdenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos)
		{
			int returnValue = 0;

			if(llamadaUno.Duracion > llamadaDos.Duracion)
			{
				returnValue = 1;
			}
			else if(llamadaUno.Duracion < llamadaDos.Duracion)
			{
				returnValue = -1;
			}
			return returnValue;
		}
		#endregion
	}
}