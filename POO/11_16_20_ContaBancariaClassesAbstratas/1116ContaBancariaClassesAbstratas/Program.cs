using System;
using System.Collections.Generic;

namespace _1116ContaBancariaClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebe quantos funcionários serão registrados
            Console.Write("Entre com o número de funcionários: ");
            int i = Int32.Parse(Console.ReadLine());
            List<Funcionario> funcionario = new List<Funcionario>(i);

            //Recebe dados dos funcionários
            for (int n = 0; n < i; n++)
            {
                Console.WriteLine("\nInsira os dados do funcionário #" + (n + 1) + ":");

                //Recebe a informação se é terceirizado
                Console.Write("É Terceirizado? (S/N)");
                string cv = Console.ReadLine().ToUpper();

                //Valida a resposta se o funcionário é terceirizado
                while (cv != "S" && cv != "N")
                {
                    Console.WriteLine("Insira uma resposta válida!");
                    Console.Write("É Terceirizado? (S/N)");
                    cv = Console.ReadLine().ToUpper();
                }

                //Recebe nome
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                //Declara uma variável para o adicional e, caso seja terceirizado pergunta o valor desta
                double adic = 0;
                if (cv == "S")
                {
                    Console.Write("Adicional: R$");
                    adic = Double.Parse(Console.ReadLine());
                }

                //Recebe numero de horas
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                //Recebe valor por hora
                Console.Write("Valor por Hora: R$");
                double valor = double.Parse(Console.ReadLine());

                //Se o funcionário for terceirizado registra na classe FuncionarioTerceirizado
                if (cv == "S") 
                { 
                    funcionario.Add(new FuncionarioTerceirizado(nome, horas, valor, adic));
                }

                //Se o funcionário NÃO for terceirizado registra na classe Funcionario
                else if (cv == "N")
                {
                    funcionario.Add(new Funcionario(nome, horas, valor));
                }
            }

            //Exibe classe Funcionario que tem como herdeira classe FuncionarioTerceirizado
            foreach (Funcionario obj in funcionario)
            {
                Console.WriteLine("\n" + obj.ToString());
            }
        }
    }
}
