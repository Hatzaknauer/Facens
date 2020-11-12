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
            Console.Write("Insira o valor do depósito inicial: R$");
            double qtd = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            saldo += qtd;
        }

        //Cálculo de depósito
        public void Deposito(double qtd)
        {
            saldo += qtd;
        }

        //Cálculo de saque
        public void Saque(double qtd)
        {
            saldo-= qtd;
            saldo-= 5;
        }

        //Método para alteração de nome
        public void AlteraNome(string nome)
        {
            _titular = nome;
        }

        //Método To String para mostrar informações mais rapidamente
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