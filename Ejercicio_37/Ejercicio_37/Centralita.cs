using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
	public class Centralita
	{
		private List<Llamada> listaDeLlamadas;
		private string razonSocial;

		#region Propiedades

		public float GananciasPorLocal
		{
			get
			{
				float ganancia = 0;

				foreach(Llamada llamada in this.Llamadas)
				{
					if(llamada is Local)
					{
						ganancia += llamada.CalcularCosto();
					}
				}
				return ganancia;
			}
		}

		public float GananciasPorProvincial
		{
			get
			{
				float ganancia = 0;

				foreach(Llamada llamada in this.Llamadas)
				{
					if(llamada is Provincial)
					{
						ganancia += llamada.CalcularCosto();
					}
				}
				return ganancia;
			}
		}

		public float GananciasPorTotal
		{
			get
			{
				float ganancia = 0;

				foreach(Llamada llamada in this.Llamadas)
				{
					ganancia += llamada.CalcularCosto();
				}
				return ganancia;
			}
		}

		public List<Llamada> Llamadas
		{
			get
			{
				return this.listaDeLlamadas;
			}
		}

		#endregion

		#region Métodos

		public Centralita()
		{
			this.listaDeLlamadas = new List<Llamada>();
		}

		public Centralita(string nombreEmpresa) : this()
		{
			this.razonSocial = nombreEmpresa;
		}

		private float CalcularGanancia(TipoLlamada tipo) //ANALIZAR DE DONDE VIENE TIPO DE LLAMADA
		{
			switch(TipoLlamada)
			{
				case Local:
					return this.GananciasPorLocal;
					break
				case Provincial:
					return this.GananciasPorProvincial;
					break
				case Todas:
					return this.GananciasPorTotal;
					break
			}
		}

		public string Mostrar()
		{
			StringBuilder datos = new StringBuilder("");

			datos.Append(this.Duracion.ToString());
			datos.Append(this.nroDestino);
			datos.Append(this.nroOrigen);

			datos.Append("\nRAZÓN SOCIAL: " + this.razonSocial);
			datos.Append("\nGANANCIAS POR LLLAMADAS LOCALES: " + this.CalcularGanancia(TipoLlamada.Local));
			datos.Append("\nGANANCIAS POR LLLAMADAS PROVINCIALES: " + this.CalcularGanancia(TipoLlamada.Provincial));
			datos.Append("\nGANANCIA TOTAL: " + this.CalcularGanancia(TipoLlamada.Todas));

			foreach (Llamada llamada in this.Llamadas)
			{
				datos.Append("\n" + llamada.Mostrar());
			}
			return datos.ToString();
		}

		public void OrdenarLlamadas()
		{
			
		}
		#endregion
	}
}