using System;
using System.Globalization;

namespace _1019ArrayClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variável que irá definir o tamanho do vetor
            int n;

            //Recebe tamanho do vetor
            Console.Write("Insira a quantidade de produtos a serem cadastrados: ");

            //Define o tamanho do vetor com base no que usuário inseriu
            Produto[] vect = new Produto[n = int.Parse(Console.ReadLine())];

            //Variável para calcular a média
            double qtd = n;

            //Variável soma       
            double sum = 0.0;

            //Utilização do comando for para percorrer o vetor
            for (int i = 0; i < vect.Length; i++)
            {
                //Recebe produto
                Console.Write("Insira o nome do produto: ");
                string name = Console.ReadLine();

                //Recebe valor do produto
                Console.Write("Insira o valor do produto: R$");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Entrada dos elementos no vetor pelo usuário
                vect[i] = new Produto { Name = name, Price = price };

            }

            //Utilização do for para percorrer o vetor
            for (int i = 0; i < n; i++)
            {
                //Somatoria dos elementos inseridos
                sum += vect[i].Price;
            }

            Console.WriteLine("Soma total do valor dos produtos: R$" + sum.ToString("F2", CultureInfo.InvariantCulture));

            //Calcula a média e exibe
            Console.WriteLine("Média dos preços: R$" + sum / qtd);

        }
    }
}