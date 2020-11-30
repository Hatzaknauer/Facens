using System;

namespace _1123FormasGeometricasMetodosAbstratos
{
	class Circulo : Forma{
		public double Raio;

		//Método Construtor
		public Circulo(double raio, Color cor) : base(cor)
		{
			Raio = raio;
		}

		//Metodo de calculo da area
	public override double Area()
	{
		return Math.PI * Raio * Raio;
	}
	}
}