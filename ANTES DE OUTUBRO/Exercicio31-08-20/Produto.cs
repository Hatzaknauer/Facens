using System;

namespace POOProduto
{
	public class Produto
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
    }
}