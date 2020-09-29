using System;
using System.Globalization;

namespace Dolares
{
	public class Conversor
    {
        public static double cotacao;
        public static double valor;

        public static double CalculaDolar()
        { 
            return (cotacao * valor )* 1.06;
        }

        public override string ToString()
        {
            return "\nCotação do dólar: R$ "
            + cotacao.ToString("F2", CultureInfo.InvariantCulture)
            + "\nValor do produto: $ "
            + valor.ToString("F2", CultureInfo.InvariantCulture)
            +"\nSomado ao IOF de 6%"
            +"\nValor a ser pago em reais: R$ "
            + CalculaDolar().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}