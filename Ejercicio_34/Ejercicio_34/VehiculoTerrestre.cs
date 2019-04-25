using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
	public enum Colores
	{
		Rojo,
		Blanco,
		Azul,
		Gris,
		Negro,
	}

	public class VehiculoTerrestre
	{
		protected short cantidadRuedas;
		protected short cantidadPuertas;
		private short cantidadMarchas;
		protected Colores color;

		public VehiculoTerrestre(short ruedas, short puertas, Colores color, short marchas)
		{
			this.cantidadRuedas = ruedas;
			this.cantidadPuertas = puertas;
			this.color = color;
			this.cantidadMarchas = marchas;
		}
	}
}