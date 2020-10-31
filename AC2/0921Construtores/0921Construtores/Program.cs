using System;
using System.Globalization;

namespace _0921Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recebe o nome do console
            Console.Write("Digite o nome do console: ");
            string nome = Console.ReadLine();

            // Recebe o preço do console
            Console.Write("Digite o preço do console: ");
            double preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Recebe quanto há de estoque
            Console.Write("Digite a quantidade em estoque: ");
            int quantidade = Int32.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Uso do método construtor
            Produto ps4 = new Produto(nome, preco, quantidade);

            Console.WriteLine(ps4.ToString());

            // Adiciona produtos ao estoque estoque
            Console.Write("Quantos produtos gostaria de adicionar ao estoque? ");
            quantidade = Int32.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ps4.AdicionarProdutos(quantidade);

            Console.WriteLine(ps4.ToString());

            // Remove produtos do estoque
            Console.Write("Quantos produtos gostaria de remover do estoque? ");
            quantidade = Int32.Parse(Console.ReadLine());
            ps4.RemoverProdutos(quantidade);

            Console.WriteLine(ps4.ToString());
        }
    }
}