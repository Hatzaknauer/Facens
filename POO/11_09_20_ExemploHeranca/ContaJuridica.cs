using System;
using System.Globalization;

namespace ExemploHeranca
{
	//Classe ContaJuridica herdando classe Conta
	class ContaJuridica : Conta
	{
		//Declara��es das vari�veis e uso do encapsulamento
		public double EmprestimoLimite;

		//Cria��o do construtor com par�metros utilizando o da Classe Conta

		//m�todo construtor de Conta Juridica realizando Hierarquia de vari�veis da Conta para Conta juridica
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
				//adiciona ao saldo e remove do limite do empr�stimo
				Saldo += saldoTotal;
				EmprestimoLimite -= saldoTotal;
			}
		}

		//metodo ToString para manter informa��es atualizadas
        public override string ToString()
        {
			return "ID: " + Numero +
				"\nTitular: " + Titular +
				"\nSaldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture) +
				"\nEmpr�stimo Limite: R$" + EmprestimoLimite.ToString("F2", CultureInfo.InvariantCulture) +
				"\nSaldo Total: R$" + (Saldo + EmprestimoLimite).ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }	
}