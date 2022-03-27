using System;
using System.Globalization;

namespace Produto_ToString
{
    class Produto
    {
        public string nome;
		public double preco;
		public int quantidade;

        public double ValorTotalEstoque(int quantidade, double preco)
        {
            double x = quantidade * preco;
            return x;
        }

        public void AdicionarProdutos(int entrada)
        {
            quantidade = quantidade + entrada;
        }

        public void RemoverProdutos(int entrada)
        {
            quantidade = quantidade - entrada;
        }

        public override string ToString()
        {
            return "Nome do produto: " 
            +nome
            + "\nR$"
            + preco.ToString("F2", CultureInfo.InvariantCulture)
            + "\n"
            + quantidade
            + " unidades\nTotal: $ "
            + ValorTotalEstoque(quantidade, preco).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
