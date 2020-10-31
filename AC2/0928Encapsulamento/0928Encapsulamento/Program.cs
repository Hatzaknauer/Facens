using System;
using System.Globalization;

namespace _0928Encapsulamento
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Método Construtor
            Produto p = new Produto("PS5", 6000.00, 10);

            //Exibe o produto com construtor
            Console.WriteLine(p.ToString());

            //NOME > Set com Properties
            Console.Write("Insira o nome do console se desejar atualizar: ");
            p.Nome = (Console.ReadLine());

            //QUANTIDADE > Set comum
            Console.Write("Insira a quantidade de consoles: ");
            p.SetQuantidade(int.Parse(Console.ReadLine()));

            //PREÇO > Set comum
            Console.Write("Insira o valor do console: ");
            p.SetPreco(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            //EXIBE INFORMAÇÕES com Get
            Console.Write(
                p.Nome.ToString()
                + ", R$ "
                + p.GetPreco().ToString()
                + ", "
                + p.GetQuantidade().ToString()
                + " unidades, Total: R$ "
                + p.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)); 
        }
    } 
}
