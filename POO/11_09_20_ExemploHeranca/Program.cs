using System;
using System.Globalization;

namespace ExemploHeranca 
{   
    class Program
    {
        static void Main(string[] args) 
        { 
            /*Declaração de uma conta
             * ID 8010
             * Titular "Lara Croft"
             * 100 Reais de saldo
             * 500 reais para empréstimo*/

            ContaJuridica conta = new ContaJuridica(8010, "Lara Croft", 100.0, 500.0);

            //Exibe informações da conta e recebe o valor do saque
            Console.WriteLine(conta.ToString());
            Console.Write("\nInsira um valor entre 0 e "+conta.Saldo+" para sacar: ");
            double valor = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);

            //Exibe informações atualizadas da conta
            Console.WriteLine(conta.ToString());

            //Recebe valor do depósito
            Console.Write("Insira o valor do depósito: ");
            double depot = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(depot);

            //Exibe informações atualizadas da conta
            Console.WriteLine(conta.ToString());

            //Pergunta se necessita de um empréstimo
            Console.Write("Deseja realizar um empréstimo? (S/N) ");
            string empr = Console.ReadLine().ToUpper();
            //Caso seja informada uma opção inválida, pergunta novamente.
            while (empr != "S" && empr!= "N")
            {
                Console.WriteLine("Favor inserir uma opção válida... (S para sim e N para não): ");
                empr = Console.ReadLine();
            }

            //Caso deseje fazer um empréstimo
            if (empr == "S")
            {
                //Valor do empréstimo perguntado para o usuário
                Console.WriteLine("Qual valor deseja emprestar? (Limite: R$" + conta.EmprestimoLimite + ",00) ");
                double emprestou = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Emprestimo(emprestou);

                //Exibe informações atualizadas da conta
                Console.WriteLine(conta.ToString());
                //Fecha o programa
                Console.WriteLine("\nPressione qualquer tecla para sair.");
                Console.ReadKey();
            }
            else
            {
                //Caso não queira fazer empréstimo pergunta se quer informações da conta novamente
                Console.WriteLine("Deseja visualizar as informações da conta novamente? (S/N) ");
                string sn = Console.ReadLine().ToUpper();
                if (sn == "S")
                {
                    //Se sim, exibe
                    Console.WriteLine(conta.ToString());
                    Console.WriteLine("\nPressione qualquer tecla para sair.");
                    Console.ReadKey();
                }
                //Se não, encerra operações
                else
                {
                    Console.WriteLine("\nPressione qualquer tecla para sair.");
                    Console.ReadKey();
                }
            }
        }
    }
}
