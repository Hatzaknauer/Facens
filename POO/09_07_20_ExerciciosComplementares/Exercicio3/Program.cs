using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Insira o nome do aluno: ");
            a.nome = Console.ReadLine();

            Console.Write("Insira as notas do aluno:\n");
            a.CalculaNota();

            Console.Write(a.ToString());
        }
    }
}
