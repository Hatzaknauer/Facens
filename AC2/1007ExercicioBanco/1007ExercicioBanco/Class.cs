using System;
using System.Globalization;

namespace _1007ExercicioBanco
{
	public class Cadastro
    {
        string _conta, _titular;
        double saldo = 0;

        public Cadastro(string conta, string titular)
        {
            _conta = conta;
            _titular = titular;
        }

        public void DepositoInicial()
        {           
            Console.Write("Insira o valor do dep�sito inicial: R$");
            double qtd = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            saldo += qtd;
        }

        //C�lculo de dep�sito
        public void Deposito(double qtd)
        {
            saldo += qtd;
        }

        //C�lculo de saque
        public void Saque(double qtd)
        {
            saldo-= qtd;
            saldo-= 5;
        }

        //M�todo para altera��o de nome
        public void AlteraNome(string nome)
        {
            _titular = nome;
        }

        //M�todo To String para mostrar informa��es mais rapidamente
        public override string ToString()
        {
            return "Dados da conta: Conta " 
                + _conta 
                + ", Titular: " 
                + _titular 
                + ", Saldo: R$" 
                + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}