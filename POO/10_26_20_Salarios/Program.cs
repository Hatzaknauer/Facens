using System;
using System.Collections.Generic;
using System.Globalization;

namespace _1026TemaSalarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando número de funcionários e lista
            Console.Write("Insira a quantidade de funcionários que serão registrados: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n------ REGISTRO DE FUNCIONÁRIOS ------");

            List<Funcionario> funcionarios = new List<Funcionario>(n);

            //Cadastrando os funcionários com o construtor
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nID do funcionário: " + (i + 1));
                Console.Write("Insira o nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.Write("Insira o salário do funcionário: ");
                double salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios.Add(new Funcionario(i + 1, nome, salario));
                Console.WriteLine("----- CADASTRADO ------");
            }

            //Exibe funcionários cadastrados
            Console.WriteLine("\n\n" + "----- FUNCIONÁRIOS CADASTRADOS -----");
            foreach (Funcionario obj in funcionarios)
            {
                Console.WriteLine("\n" + obj.ToString());
            }

            //Recebe ID do funcionário que receberá aumento
            Console.Write("Insira o ID do funcionário que terá o salário aumentado: ");
            int x = Int32.Parse(Console.ReadLine());
            Funcionario w = funcionarios.Find(ff => ff.Id == x);

            // Verifica a existência do ID inserido
            if (w == null)
            {
                Console.WriteLine("ID não encontrado... Abortando operação.");
            }
            else
            {
                Console.Write("Porcentagem do aumento: %");
                double aumento = Double.Parse(Console.ReadLine());
                w.aumentarSalario(aumento);
            }          

            // Exibe informações dos funcionários
            foreach (Funcionario obj in funcionarios)
            {
                Console.WriteLine("\n" + obj.ToString());
            }
        }
    }
}