using System;
using System.Globalization;

namespace Exercicio_2
{
	class Funcionario
    {
        public string nome;
        public double salarioBruto, imposto;

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public override string ToString()
        {
            return "\nFuncionário: "
            + nome
            + "\nSalário líquido: R$"
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AumentarSalario(double porcentagem)
        {
            salarioBruto += salarioBruto * (porcentagem / 100);
        }

    }
}