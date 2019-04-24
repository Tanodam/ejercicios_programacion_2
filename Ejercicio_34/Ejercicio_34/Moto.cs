using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
	public class Moto : VehiculoTerrestre
	{
		private short cilindrada;

		public Moto(short ruedas, short puertas, Colores color, short marchas, short cilindrada) 
		: base(ruedas,puertas,color,marchas)
		{
			this.cilindrada = cilindrada;
		}
	}
}