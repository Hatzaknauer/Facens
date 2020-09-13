using System;
using System.Globalization;

namespace MaisVelho
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();

            // Informações de pessoa 1
            Console.Write("Insira o nome da pessoa Nº1: ");
            a.nome = Console.ReadLine();

            Console.Write("Insira a idade da pessoa Nº1: ");
            a.idade = Int32.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Informações de pessoa 2
            Console.Write("\n" + "Insira o nome da pessoa Nº2: ");
            b.nome = Console.ReadLine();

            Console.Write("Insira a idade da pessoa Nº2: ");
            b.idade = Int32.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calcula quem é o mais velho
            if (a.idade > b.idade)
            {
                Console.WriteLine("\n" + a.nome + " tem mais idade que " + b.nome + "!");
            }
            else if (b.idade > a.idade)
            {
                Console.WriteLine("\n" + b.nome + " tem mais idade que " + a.nome + "!");
            }
            else if (a.idade == b.idade)
            {
                Console.WriteLine("\n" + "Ambos têm a mesma idade!");
            }
            else
            {
                Console.WriteLine("\n" + "Algo deu errado, por favor tente novamente.");
            }
        }
    }
}
