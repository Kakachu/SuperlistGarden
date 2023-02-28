using Microsoft.EntityFrameworkCore;
using SuperlistGarden.Context;
using SuperlistGarden.Models;
using SuperlistGarden.Repositories.Interfaces;

namespace SuperlistGarden.Repositories
{
	public class ProdutoRepository : IProdutoRepository
	{
		private readonly AppDbContext _context;

		public ProdutoRepository(AppDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Produto> Produtos => _context.Produtos.Include(c => c.Categoria);

		public IEnumerable<Produto> IsProdutoDestaque => _context.Produtos
									.Where(p => p.IsProdutoDestaque)
									.Include(c => c.Categoria);

		public IEnumerable<Produto> Quantidade => _context.Produtos.Include(p => p.Quantidade);

		public Produto GetProdutoById(int produtoId)
		{
			return _context.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
		}
	}
}
