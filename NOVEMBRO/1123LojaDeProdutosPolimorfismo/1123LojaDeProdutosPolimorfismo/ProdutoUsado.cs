using System;
using System.Globalization;

namespace _1123LojaDeProdutosPolimorfismo
{
    class ProdutoUsado : Produto
    {
        DateTime Fabricacao = new DateTime();
        public ProdutoUsado(string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            Fabricacao = fabricacao;
        }
        public override string PrecoTag()
        {
            return base.PrecoTag()
                + " - Fabricação: (" + Fabricacao.ToString("dd/MM/yyyy")+")";
        }
    }
}