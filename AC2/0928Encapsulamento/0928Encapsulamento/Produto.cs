using System;
using System.Globalization;

public class Produto
{
	public string _nome { get; private set; }
	public double _preco;
	public int _quantidade;

	#region construtor
	public Produto(string nome, double preco, int quantidade)
	{
		_nome = nome;
		_preco = preco;
		_quantidade = quantidade;
	}
	#endregion

	//GET SET NOME PROPERTIES
	public string Nome {
		get
		{
			return _nome;
		}

		set
		{ 
			//SE NOME NÃO FOR VAZIO > ATUALIZA O NOME
			if (value != null && value.Length > 1) 
			{
				_nome = value;
			}
		} 
	}

	# region GET SET PRECO
	//GET
	public double GetPreco()
	{
		return _preco;
	}

	//SET
	public void SetPreco(double preco)
	{
		//SE PRECO NÃO FOR VAZIO > ATUALIZA PREÇO
		if (preco >= 0)
		{
			_preco = preco;
		}
	}
	#endregion

	#region GET SET QUANTIDADE
	//GET
	public int GetQuantidade()
	{
		return _quantidade;
	}

	//SET 
	public void SetQuantidade(int quantidade)
	{
		if (quantidade > 0)
		{
			_quantidade = quantidade;
		}
	}
	#endregion

	#region métodos para cálculo de estoque
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
	#endregion
	

	public override string ToString()
	{
		return _nome
			+ ", R$ "
			+ _preco.ToString("F2", CultureInfo.InvariantCulture)
			+ ", "
			+ _quantidade
			+ " unidades, Total: R$ "
			+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
	}
}