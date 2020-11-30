using System;
using System.Globalization;

namespace _1123LojaDeProdutosPolimorfismo
{
    class ProdutoImportado : Produto
    {
        double Taxa;
        
        public ProdutoImportado(string nome, double preco, double taxa) : base (nome, preco)
        {
            Taxa = taxa;
        }

        public override string PrecoTag()
        {
            return base.PrecoTag()
                + "(Taxa: " + Taxa.ToString("F2", CultureInfo.InvariantCulture)+")";
        }
    }
}