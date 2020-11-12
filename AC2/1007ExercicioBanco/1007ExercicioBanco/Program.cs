using System;
using System.Globalization;

namespace _1007ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recebe o número da conta
            Console.Write("Digite o número da conta: ");
            string conta = Console.ReadLine();

            // Recebe o nome do titular da conta
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();

            //Cadastra o usuário
            Cadastro usuario = new Cadastro(conta, titular);

            // Pergunta se deseja fazer um depósito inicial
            Console.Write("Haverá depósito inicial? (S/N): ");
            string soun = Console.ReadLine().ToLower();
            while(soun != "s" && soun != "n")
            {
                Console.Write("Haverá depósito inicial? Digite 'S' para sim e 'N' para não: ");
                soun = Console.ReadLine().ToLower();
            }
            //Se sim, chama o método de depósito inicial
            if (soun == "s")
            {
                usuario.DepositoInicial();
            }
            //Se não, o padrão do saldo é 0.

            //Exibe informações
            Console.WriteLine("\n" + usuario.ToString());
            
            //Recebe valor de depósito
            Console.Write("Insira um valor para depósito: R$");
            double dep = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            usuario.Deposito(dep);

            //Exibe informações
            Console.WriteLine(usuario.ToString());

            //Recebe valor de saque
            Console.Write("Insira um valor para sacar: R$");
            double saq = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            usuario.Saque(saq);

            //Exibe informações
            Console.WriteLine(usuario.ToString());

            //Pergunta se deseja alterar nome
            Console.Write("Há alguma alteração a ser feita no nome do titular? (S/N) ");
            string yorn = Console.ReadLine().ToLower();

            while (yorn != "s" && yorn != "n")
            {
                Console.Write("Há alguma alteração a ser feita no nome do titular? Digite 'S' para sim e 'N' para não: ");
                yorn = Console.ReadLine().ToLower();
            }

            //Caso sim, pede o novo nome e exibe dados atualizados
            if (yorn == "s")
            {
                Console.Write("Digite o nome atualizado: ");
                string nome = Console.ReadLine();
                usuario.AlteraNome(nome);
                Console.WriteLine(usuario.ToString());
            }
            //Caso não, encerra o programa
            else if (yorn == "n")
            {
                Console.WriteLine("Pressione qualquer tecla para fechar o programa... ");
                Console.ReadKey();
            }
        }
    }
}