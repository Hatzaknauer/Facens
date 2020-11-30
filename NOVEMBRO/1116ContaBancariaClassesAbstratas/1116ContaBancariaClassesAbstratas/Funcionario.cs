using System;
using System.Globalization;
    
namespace _1116ContaBancariaClassesAbstratas
{
    class Funcionario
    {
        //Declara��o de vari�veis
        public string Nome;
        public int Horas;
        public double ValorHora;

        //M�todo construtor
        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        //C�lculo do pagamento do funcion�rio
        public virtual double Pagamento()
        {
            double pgto;
            pgto = Horas*ValorHora;
            return pgto;
        }

        //M�todo To String
        public override string ToString()
        {
            return
                "Nome: " + Nome +
                "\nPagamento: R$" + Pagamento().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}