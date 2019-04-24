using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
	public class Persona
	{
		protected long dni;
		protected string nombre;

		#region Constructores

		public Persona(long dni, string nombre) : this(nombre)
		{
			this.Dni = dni;
		}

		public Persona(string nombre)
		{
			this.Nombre = nombre;
		}

		#endregion

		#region Propiedades

		public long Dni
		{
			get
			{
				return this.dni;
			}
			set
			{
				this.dni = value;
			}
		}

		public string Nombre
		{
			get
			{
				return this.nombre;
			}
			set
			{
				this.nombre = value;
			}
		}
 		
 		#endregion

		#region Métodos

		public string MostrarDatos()
		{
			string datos = "";

			datos += this.Nombre;
			datos += this.Dni;

			return datos;
		}

		#endregion
	}
}