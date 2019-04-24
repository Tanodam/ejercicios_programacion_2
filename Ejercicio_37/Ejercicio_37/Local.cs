using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
	public class Local : Llamada
	{
		private float costoLlamada;

		#region Propiedades

		public float CostoLlamada
		{
			get
			{
				return this.CalcularCosto();
			}
		}

		#endregion

		#region Métodos

		private float CalcularCosto()
		{
			return this.costoLlamada * this.Duracion;
		}

		public Local(Llamada llamada, float costo) 
		{
			this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo);
		}

		public Local(string origen, float duracion, string destino, float costo)
		{
			this.duracion = duracion;
			this.nroDestino = destino;
			this.nroOrigen = origen;
			this.costoLlamada = costo;
		}

		public string Mostrar()
		{
			StringBuilder datos = new StringBuilder("");

			datos.Append(base.Mostrar());
			datos.Append(this.CostoLlamada.ToString());

			return datos.ToString();
		}

		#endregion
	}
}