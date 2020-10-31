using System;

namespace _1021VetoresHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaro um hotel com 10 quartos
            Hotel[] hotel = new Hotel[10];

            //Construo o hotel vazio
            for (int i = 0; i <10; i++)
            {
                hotel[i] = new Hotel(i, null, null);
            }

            //Recebe quantos hóspedes serão registrados pelo programa
            Console.WriteLine("Insira a quantidade de hóspedes a ser registrado: ");
            int hspd = int.Parse(Console.ReadLine());

            //Loop para adição de hóspedes
            for (int i = 0; i < hspd; i++)
            {
                //Recebe número do quarto
                Console.Write("Insira o número do quarto a ser alugado (0 - 9): ");
                int quarto = int.Parse(Console.ReadLine());

                //Verifica se o quarto está ocupado
                while (hotel[quarto].GetNome() != null)
                {
                    Console.Write("Quarto indisponível, escolha outro quarto: ");
                    quarto = int.Parse(Console.ReadLine());
                }

                //Recebe o nome do hóspede
                Console.Write("Insira o nome do hóspede: ");
                string nome = Console.ReadLine();

                //Recebe e-mail do hóspede
                Console.Write("Insira o e-mail do hóspede: ");
                string email = Console.ReadLine();

                //Define quarto ocupado com as informações
                hotel[quarto] = new Hotel(quarto, nome, email);
            }

            //Verifica o objeto que está em uso e exibo
            foreach(Hotel quarto in hotel)
            {
                Console.WriteLine(quarto.ToString());
            }            
        }
    }
}
