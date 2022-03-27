using System;
using System.Globalization;

namespace Exercicio_1
{
    class Retangulo
    {
        public static double altura, largura;

        public double Area()
        {
            return altura * largura;
        }

        public double Perimetro()
        {
            return (altura * 2) + (largura * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt((altura * altura) + (largura * largura));
        }

        public override string ToString()
        {
            return "\nÁrea: " + Area()
                + "\nPerímetro: " + Perimetro()
                + "\nDiagonal: " + Diagonal()
                + "\n";
        }
    }
}