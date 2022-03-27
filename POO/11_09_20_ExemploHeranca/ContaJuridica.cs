using System;
using System.Globalization;

namespace ExemploHeranca
{
	//Classe ContaJuridica herdando classe Conta
	class ContaJuridica : Conta
	{
		//Declarações das variáveis e uso do encapsulamento
		public double EmprestimoLimite;

		//Criação do construtor com parâmetros utilizando o da Classe Conta

		//método construtor de Conta Juridica realizando Hierarquia de variáveis da Conta para Conta juridica
		public ContaJuridica
		(int numero, string titular, double saldo, double emprestimoLimite)
		: base(numero, titular, saldo)

		{
			EmprestimoLimite = emprestimoLimite;
		}
		public void Emprestimo(double saldoTotal)
		{
			if (saldoTotal <= EmprestimoLimite)
			{
				//adiciona ao saldo e remove do limite do empréstimo
				Saldo += saldoTotal;
				EmprestimoLimite -= saldoTotal;
			}
		}

		//metodo ToString para manter informações atualizadas
        public override string ToString()
        {
			return "ID: " + Numero +
				"\nTitular: " + Titular +
				"\nSaldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture) +
				"\nEmpréstimo Limite: R$" + EmprestimoLimite.ToString("F2", CultureInfo.InvariantCulture) +
				"\nSaldo Total: R$" + (Saldo + EmprestimoLimite).ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }	
}