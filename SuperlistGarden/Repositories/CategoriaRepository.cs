using SuperlistGarden.Context;
using SuperlistGarden.Models;
using SuperlistGarden.Repositories.Interfaces;

namespace SuperlistGarden.Repositories
{
	public class CategoriaRepository : ICategoriaRepository
	{
		private readonly AppDbContext _context;

		public CategoriaRepository(AppDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Categoria> Categorias => _context.Categorias;

	}
}
