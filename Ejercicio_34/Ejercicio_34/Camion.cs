using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
	public class Camion : VehiculoTerrestre
	{
		private int pesoCarga;

		public Camion(short ruedas, short puertas, Colores color, short marchas, int carga) 
		: base(ruedas,puertas,color,marchas)
		{
			this.pesoCarga = carga;
		}
	}
}