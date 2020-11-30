using System;
using System.Globalization;

namespace _1123LojaDeProdutosPolimorfismo
{
    class Produto
    {
        string Nome;
        double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string PrecoTag()
        {
            string precoTag = "Nome: " + Nome + "- Preço: R$" + Preco.ToString("F2", CultureInfo.InvariantCulture);
            return precoTag;
        }
    }
}