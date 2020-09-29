using System;
using System.Globalization;

namespace Dolares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a cotação do dólar: R$");
            Conversor.cotacao = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o valor do produto em dólares: $ ");
            Conversor.valor = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conversor a = new Conversor();
            Console.WriteLine(a.ToString());
        }
    }
}