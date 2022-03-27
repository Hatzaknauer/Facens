using System;
using System.Globalization;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a = new Funcionario();

            Console.Write("Insira o nome do funcionário: ");
            a.nome = Console.ReadLine();

            Console.Write("Insira o salário bruto do funcionário: ");
            a.salarioBruto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o imposto: ");
            a.imposto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write(a.ToString());

            Console.Write("\n\nInsira a porcentagem para calcular no salário do funcionário: ");
            a.AumentarSalario(Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.Write("\nDados atualizados: " + a.ToString());

            Console.ReadKey();
        }
    }
}
