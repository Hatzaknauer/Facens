using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo a = new Retangulo();

            Console.Write("Insira a altura do triângulo: ");
            Retangulo.altura = Double.Parse(Console.ReadLine());

            Console.Write("Insira a largura do triângulo: ");
            Retangulo.largura = Double.Parse(Console.ReadLine());

            Console.Write(a.ToString());
        }
    }
}
