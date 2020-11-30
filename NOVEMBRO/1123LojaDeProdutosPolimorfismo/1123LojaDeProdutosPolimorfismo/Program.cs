using System;
using System.Collections.Generic;
using System.Globalization;

namespace _1123LojaDeProdutosPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebe número de produtos que serão registrados
            Console.Write("Insira o número de produtos que você deseja registrar: ");
            int n = Int32.Parse(Console.ReadLine());

            //Cria lista com tamanho inserido
            List<Produto> produtos = new List<Produto>(n);

            Console.WriteLine("\n------- REGISTRO DE PRODUTOS -------");
            //Recebe os dados dos produtos
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("\nProduto #" + (i+1) + ":");
                //Recebe se é Comum, Usado ou Importado
                Console.Write("O produto é Comum, Usado ou Importado? (C/U/I)?");
                string cui = Console.ReadLine().ToUpper();

                //Valida info recebida
                while (cui != "C" && cui !="U" && cui != "I")
                {
                    Console.Write("Insira uma resposta válida. C para Comum /U para Usado /I para Importado)? ");
                    cui = Console.ReadLine().ToUpper();
                }

                //Recebe nome do produto
                Console.Write("Entre com o nome do produto: ");
                string nome = Console.ReadLine();

                //Recebe preço do produto
                Console.Write("Insira o preço do produto: R$");
                double valor = Double.Parse(Console.ReadLine());

                //Se for comum, adiciona à lista Produto com nome e valor
                if (cui == "C")
                {
                    produtos.Add(new Produto(nome, valor));
                }

                //Se for importado recebe a taxa do usuário
                else if (cui == "I")
                {
                    Console.Write("Insira a taxa do produto: ");
                    double taxa = Double.Parse(Console.ReadLine());
                    //adiciona à lista ProdutoImportado com nome, valor e taxa
                    produtos.Add(new ProdutoImportado(nome, valor, taxa));
                }

                //Se for importado recebe a data de fabricação do usuário
                else if (cui == "U")
                {
                    // Adiciona a tag (usado) ao nome do produto
                    nome = nome + " (usado) ";
                    Console.Write("Insira a data de fabricação do produto (DD/MM/AAAA): ");
                    DateTime fabricacao = DateTime.Parse(Console.ReadLine());
                    //adiciona à lista ProdutoUsado com nome, valor e taxa de fabricação
                    produtos.Add(new ProdutoUsado(nome, valor, fabricacao));
                }
            }

            Console.WriteLine("\n ------ Etiquetas ------ ");
            //Exibe informações
            foreach (Produto obj in produtos)
            {
                Console.WriteLine(obj.PrecoTag()+"\n");
            }

            Console.ReadKey();
        }
    }
}