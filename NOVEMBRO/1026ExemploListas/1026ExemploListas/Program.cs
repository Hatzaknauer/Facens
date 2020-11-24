using System;
using System.Collections.Generic;

namespace _1026ExemploListas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando a lista de strings
            List<string> list = new List<string>();
            //Adiciono elementos na lista
            list.Add("Fábio");
            list.Add("Wilson");
            list.Add("Angelina");
            list.Add("Eliney");
            list.Add("Andre");
            //Adiciona um elemento na posição sugerida
            list.Insert(2, "Lucas");

            //Conto quantos elementos tem na minha lista
            Console.WriteLine("Qnt de elementos na Lista: " + list.Count);

            //Encontrar o primeiro elemento que inicia com a letra A, com uma função lambda
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);

            //Encontrar o último elemento que inicia com a letra A, com uma função lambda
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último elemento que começa com a letra A: " + s2);

            //Buscar elementos pela sua posição
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira Posição de ‘A’: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última Posição de ‘A’: " + pos2);

            //Buscar todos os elementos com tamanho igual a 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
                //Remover elementos da lista
                list.Remove("Andre");
                Console.WriteLine("===================");
                foreach (string objeto in list)
                {
                    Console.WriteLine(objeto);
                }

            }
            
            //Remover determinado elemento da lista
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("+++++++++++++++++++");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover elemento de determinada posição lista
            list.RemoveAt(3);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover elementos da lista a partir da posição e quantos elementos
            list.RemoveRange(1, 2);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
