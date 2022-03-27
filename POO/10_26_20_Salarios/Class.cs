using System;
using System.Collections.Generic;
using System.Globalization;

namespace _1026TemaSalarios
{
	public class Funcionario
	{
		//Variáveis
		public int Id = 1;
		string Nome;
		double Salario;

		//Construtor
		public Funcionario(int id, string nome, double salario)
		{
			Id=id;
			Nome = nome;
			Salario = salario;
		}		

		//Aumentar Salário
		public void aumentarSalario(double porcetagem)
		{
			porcetagem /= 100;
			porcetagem += 1;
			Salario *= porcetagem;
		}

		//Método To String
		public override string ToString()
		{
			return "ID: " + Id
				+ "\nNome: " + Nome
				+ "\nSalário: R$" + Salario.ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}