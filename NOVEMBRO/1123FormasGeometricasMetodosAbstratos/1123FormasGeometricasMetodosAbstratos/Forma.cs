using System;


namespace _1123FormasGeometricasMetodosAbstratos
{
	abstract class Forma
	{
		public Color Color;

		//M�todo Construtor
		public Forma(Color color)
		{
			Color = color;
		}

		public abstract double Area();
	}
}