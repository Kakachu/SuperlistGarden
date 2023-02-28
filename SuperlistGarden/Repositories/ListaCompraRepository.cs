using SuperlistGarden.Context;
using SuperlistGarden.Models;

namespace SuperlistGarden.Repositories
{
	public class ListaCompraRepository
	{
		private readonly AppDbContext _context;

		public ListaCompraRepository(AppDbContext context)
		{
			_context = context;
		}
	}
}
