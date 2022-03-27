using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel de numeros negativos
            int z = 0;

            //Criando uma matriz com valor inserido pelo usuário
            Console.Write("Insira o número de linhas e colunas da matriz: ");
            int i = Int32.Parse(Console.ReadLine());
            int[,] mat = new int[i, i];

            //Recebe do usuário os valores da matriz 
            for (int x = 0; x < i; x++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.WriteLine("Insira o valor que representará a linha " + (x + 1) + " da coluna " + (y + 1));
                    mat[x, y] = Int32.Parse(Console.ReadLine());

                    //Caso seja negativo adiciona o número à contagem
                    if (mat[x, y] < 0)
                    {
                        z++;
                    }
                }
            }

            //Exibe a diagonal principal...
            Console.WriteLine("Diagonal principal:");
            //...verificando se o número da linha é igual...
            for (int x = 0; x < i; x++)
            {
                //...ao numéro da coluna
                for (int y = 0; y < i; y++)
                {                 
                    //se for, faz parte da diagonal, então exibe.
                    if (x == y)
                    {
                        Console.Write(" " + mat[x, y] + " ");
                    }
                }
            }

            //exibe números negativos
            Console.Write("Total de números negativos: " + z);
        }
    }
}
