namespace PruebaGeometria
{
	public class PruebaGeometria
	{
		static String Mostrar(Rectangulo rectangulo){

			String datos;
			//Concatenar datos y retornar como String

		}
		
		public static void Main(String[] args){

			Punto primerPunto = new Punto(1,5);
			Punto segundoPunto = new Punto(3,2); 

			Rectangulo rectangulo = new Rectangulo(primerPunto,segundoPunto);

			Console.Write(rectangulo.GetArea());
			Console.Write(rectangulo.GetPerimetro());
		}		
	}
}