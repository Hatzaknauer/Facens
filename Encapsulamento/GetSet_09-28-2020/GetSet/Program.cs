using System;
using System.Globalization;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("PS5", 6000.00, 10);

            Console.Write("Insira o nome do produto: ");
            p.SetNome(Console.ReadLine());

            Console.Write("Insira o valor de UM produto: ");
            p.SetPreco(Double.Parse(Console.ReadLine()));

            Console.Write("Insira a quantidade em estoque: ");
            p.SetQuantidade(Int32.Parse(Console.ReadLine()));


            Console.Write(p.ToString());
        }
    }
}
