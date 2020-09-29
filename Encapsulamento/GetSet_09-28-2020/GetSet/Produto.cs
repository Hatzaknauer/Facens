using System;
using System.Globalization;

namespace GetSet
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public void SetPreco(double preco)
        {
            if (preco != 0 && preco > 1)
            {
                _preco = preco;
            }
        }

        public void SetQuantidade(int quantidade)
        {
            if (quantidade > 0)
            {
                _quantidade = quantidade;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade = _quantidade - quantidade;
        }

        public override string ToString()
        {
            return "\nProduto: " +
                GetNome() +
                "\nR$: " +
                GetPreco().ToString("F2", CultureInfo.InvariantCulture) +
                "\nQuantidade: " +
                GetQuantidade() + "\n\nValor total: R$: " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}