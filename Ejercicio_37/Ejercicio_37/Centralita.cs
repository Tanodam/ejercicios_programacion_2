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

				foreach(Local llamada in this.Llamadas)
				{
					ganancia += llamada.CostoLlamada;
				}
				return ganancia;
			}
		}

		public float GananciasPorProvincial
		{
			get
			{
				float ganancia = 0;

                foreach (Provincial llamada in this.Llamadas)
                {
                    ganancia += llamada.CostoLlamada;
                }
                return ganancia;
			}
		}

		public float GananciasPorTotal
		{
			get
			{
				float ganancia = 0;

                ganancia += this.GananciasPorLocal + this.GananciasPorProvincial;

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

		private float CalcularGanancia(Llamada.TipoLlamada tipo) //ANALIZAR DE DONDE VIENE TIPO DE LLAMADA
		{
			switch(tipo)
			{
				case Llamada.TipoLlamada.Local:
					return this.GananciasPorLocal;
				case Llamada.TipoLlamada.Provincial:
					return this.GananciasPorProvincial;
				case Llamada.TipoLlamada.Todas:
					return this.GananciasPorTotal;
                default:
                    return 0;
			}
		}

		public string Mostrar()
		{
			StringBuilder datos = new StringBuilder("");

			datos.Append("\nRAZÓN SOCIAL: " + this.razonSocial);
			datos.Append("\nGANANCIAS POR LLLAMADAS LOCALES: " + this.CalcularGanancia(Llamada.TipoLlamada.Local));
			datos.Append("\nGANANCIAS POR LLLAMADAS PROVINCIALES: " + this.CalcularGanancia(Llamada.TipoLlamada.Provincial));
			datos.Append("\nGANANCIA TOTAL: " + this.CalcularGanancia(Llamada.TipoLlamada.Todas));

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