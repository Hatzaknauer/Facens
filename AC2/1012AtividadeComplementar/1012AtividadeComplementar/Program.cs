using System;
using System.Globalization;

namespace _1012AtividadeComplementar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variável que irá definir o tamanho do vetor
            int n;

            //Recebe tamanho do vetor
            Console.Write("Insira a quantidade de pessoas a serem cadastradas: ");

            //Define o tamanho do vetor com base no que usuário inseriu
            Produto[] vect = new Produto[n = int.Parse(Console.ReadLine())];

            //Variável para calcular a média
            double qtd = n;

            //Variável soma       
            double sum = 0.0;

            //Utilização do comando for para percorrer o vetor
            for (int i = 0; i < vect.Length; i++)
            {
                //Recebe tamanho da pessoa
                Console.Write("Insira a altura das pessoa ("+(i+1)+"): ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Entrada dos elementos no vetor pelo usuário
                vect[i] = new Produto { Price = price };

            }

            //Utilização do for para percorrer o vetor
            for (int i = 0; i < n; i++)
            {
                //Somatoria dos elementos inseridos
                sum += vect[i].Price;
            }

            //Calcula a média e exibe
            Console.WriteLine("A média das alturas das pessoas inseridas é: " 
                + ((sum / qtd).ToString("F2", CultureInfo.InvariantCulture)));

        }
    }
}
