using System;
using System.Globalization;

namespace Produto_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto ps4 = new Produto();

            int a;
            double x;

            // Recebe o nome do console
            Console.Write("Digite o nome do console: ");
            ps4.nome = Console.ReadLine();

            // Recebe o preço do console
            Console.Write("Digite o preço do console: ");
            ps4.preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Recebe quanto há de estoque
            Console.Write("Digite a quantidade em estoque: ");
            ps4.quantidade = Int32.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calcula valor total
            x = ps4.ValorTotalEstoque(ps4.quantidade, ps4.preco);

            // Exibe informações
            Console.WriteLine("Dados atualizados: " + ps4.nome + ", " + ps4.quantidade + " unidades, Total: " + x.ToString("F2", CultureInfo.InvariantCulture) + "R$.");

            // Adiciona produtos ao estoque estoque
            Console.Write("Quantos produtos gostaria de adicionar ao estoque? ");
            a = Int32.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ps4.AdicionarProdutos(a);

            // Calcula valor total
            x = ps4.ValorTotalEstoque(ps4.quantidade, ps4.preco);

            // Exibe informações
            Console.WriteLine("Dados atualizados: " + ps4.nome + ", " + ps4.quantidade + " unidades, Total: " + x.ToString("F2", CultureInfo.InvariantCulture) + "R$.");

            // Remove produtos do estoque
            Console.Write("Quantos produtos gostaria de remover do estoque? ");
            a = Int32.Parse(Console.ReadLine());
            ps4.RemoverProdutos(a);

            // Calcula valor total
            x = ps4.ValorTotalEstoque(ps4.quantidade, ps4.preco);

            Console.WriteLine(ps4.ToString());
        }
    }
}