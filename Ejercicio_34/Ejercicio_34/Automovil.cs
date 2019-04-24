using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
	public class Automovil : VehiculoTerrestre
	{
		private int cantidadPasajeros;

		public Automovil(short ruedas, short puertas, Colores color, short marchas, int pasajeros) 
		: base(ruedas,puertas,color,marchas)
		{
			this.cantidadPasajeros = pasajeros;
		}
	}
}