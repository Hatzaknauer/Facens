using System;
using System.Globalization;

namespace _1116FolhaDePagamento
{
	sealed class ContaPoupanca : Conta 
	{
		public double TaxaJuros;

		public ContaPoupanca
		(int numero, string titular, double saldo, double taxaJuros)
		: base(numero, titular, saldo)
		{
			TaxaJuros = taxaJuros;
		}
	public void atualizacaoSaldo ()
		{
			Saldo += Saldo * TaxaJuros;
		}
		public override void Saque(double saldoTotal)
		{
			base.Saque(saldoTotal);
			Saldo -= 2.0;
		}
		
	}
}