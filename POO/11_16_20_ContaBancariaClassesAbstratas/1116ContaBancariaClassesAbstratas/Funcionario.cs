using System;
using System.Globalization;
    
namespace _1116ContaBancariaClassesAbstratas
{
    class Funcionario
    {
        //Declaração de variáveis
        public string Nome;
        public int Horas;
        public double ValorHora;

        //Método construtor
        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        //Cálculo do pagamento do funcionário
        public virtual double Pagamento()
        {
            double pgto;
            pgto = Horas*ValorHora;
            return pgto;
        }

        //Método To String
        public override string ToString()
        {
            return
                "Nome: " + Nome +
                "\nPagamento: R$" + Pagamento().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}