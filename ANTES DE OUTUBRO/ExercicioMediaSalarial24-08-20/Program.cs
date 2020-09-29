using System;
using System.Globalization;

namespace CalculaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();

            //Recebe dados da pessoa 1
            Console.Write("Insira o nome da pessoa 1: ");
            a.nome = Console.ReadLine();

            Console.Write("Insira o salário da pessoa 1: ");
            a.salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //Recebe dados da pessoa 2
            Console.Write("\nInsira o nome da pessoa 2: ");
            b.nome = Console.ReadLine();

            Console.Write("Insira o salário da pessoa 2: ");
            b.salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calcula média salarial

            double x = (a.salario + b.salario) / 2;

            // Exibe informações

            Console.Write("\nMédia salarial entre " + a.nome + " e " + b.nome + " é de " + x.ToString("F2", CultureInfo.InvariantCulture) + "R$.");
        }
    }
}
