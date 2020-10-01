using System;
using System.Linq;
namespace Exercicio_3
{
    class Aluno
    {
        public string nome;
        public double [] notas = new double [3];
        public double nf;

        public void CalculaNota()
        {
            for (int i=0; i < 3; i++) 
            {
                Console.Write("Nota " + (i+1) + ": ");
                notas[i] = Double.Parse(Console.ReadLine());
                
                if (notas[0] > 30)
                {
                    notas[0] = 30;
                }
                else if (notas[i] > 35)
                {
                    notas[i] = 35;
                }
            }
        }       
        public string Passou()
        {
            nf = notas.Sum();
            if (nf >= 60)
            {
                return "Aprovado";
            }
            else
            {
                nf = 60 - nf;
                return "Reprovado \nFaltaram: " + nf + " Pontos";              
            }
        }

        public override string ToString()
        {
            return
            "\nNotas: \n"
            + notas[0]
            + "\n"
            + notas[1]
            + "\n"
            + notas[2]
            + "\n"
            + "Nota final: "
            + notas.Sum()
            + "\n"
            + Passou();
        }

    }
}