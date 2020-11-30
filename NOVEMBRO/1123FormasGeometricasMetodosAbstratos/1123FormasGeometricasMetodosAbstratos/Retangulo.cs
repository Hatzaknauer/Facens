using System;

namespace _1123FormasGeometricasMetodosAbstratos
{
	class Retangulo : Forma
	{
		
		public double Largura;
		public double Altura;

		//M�todo Construtor
		public Retangulo(double largura, double altura, Color cor) : base(cor)
		{
			Largura = largura;
			Altura = altura;
		}
		//Metodo de calculo da area
		public override double Area()
		{
			return Largura * Altura;
		}
	}
}
