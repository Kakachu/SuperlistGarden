using SuperlistGarden.Models;

namespace SuperlistGarden.Repositories.Interfaces
{
	public interface IProdutoRepository
	{
		IEnumerable<Produto> Produtos { get; }

		IEnumerable<Produto> IsProdutoDestaque { get; }

		IEnumerable<Produto> Quantidade { get; }

		Produto GetProdutoById(int produtoId);
	}
}
