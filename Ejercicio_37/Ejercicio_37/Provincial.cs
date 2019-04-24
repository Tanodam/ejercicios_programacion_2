using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
	public enum Franja
	{
		Franja_1,
		Franja_2,
		Franja_3,
	}

	public class Provincial : Llamada
	{
		private Franja franjaHoraria;

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
			float costoTotal = 0;

			switch(this.franjaHoraria)
			{
				case Franja_1 :
						costoTotal = this.Duracion * 0.99;
						break;
				case Franja_2 :
						costoTotal = this.Duracion * 1.25;
						break;
				case Franja_3 :
						costoTotal = this.Duracion * 0.66;
						break;	
			}
			return costoTotal;
		}

		public Provincial(Franja miFranja, Llamada llamada)
		{
			this.franjaHoraria = miFranja;
			this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino);
		}

		public Provincial(string origen, float duracion, string destino)
		{
			this.duracion = duracion;
			this.nroDestino = destino;
			this.nroOrigen = origen;
		}

		public string Mostrar()
		{
			StringBuilder datos = new StringBuilder("");

			datos.Append(base.Mostrar());
			datos.Append(this.CostoLlamada.ToString());
			datos.Append(this.franjaHoraria.ToString());

			return datos.ToString();
		}

		#endregion
	}
}