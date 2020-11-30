using System;
using System.Collections.Generic;
using System.Globalization;

namespace _1123FormasGeometricasMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> list = new List<Forma>();
            //Recebe número de formas que serão listadas
            Console.Write("Entre com o número de formas: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Forma #{i}:");
                Console.Write("Retângulo ou Circulo (R / C)? ");
                char ch = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Cor: (Preto / Azul / Vermelho): ");
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'R')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangulo(largura, altura, cor));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }
                Console.WriteLine();
            }
            Console.WriteLine("Área de cada forma: ");
            foreach (Forma forma in list)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
