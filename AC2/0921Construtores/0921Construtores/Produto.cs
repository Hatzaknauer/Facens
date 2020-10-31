using System;
using System.Globalization;

namespace _0921Construtores
{
    public class Produto
    {
        string Nome;
        double Preco;
        int Quantidade;

        //CONSTRUTOR
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        #region Métodos para alteração de estoque
        public double ValorTotalEstoque(int quantidade, double preco)
        {
            double x = quantidade * preco;
            return x;
        }

        public void AdicionarProdutos(int entrada)
        {
            Quantidade += entrada;
        }

        public void RemoverProdutos(int entrada)
        {
            Quantidade -= entrada;
        }
        #endregion

        //Exibe Informações
        public override string ToString()
        {
            return
                "Dados atualizados: "
                + Nome + ", "
                + Quantidade
                + " unidades, Total: "
                + ValorTotalEstoque(Quantidade, Preco).ToString("F2", CultureInfo.InvariantCulture)
                + "R$.";
        }

    }
}