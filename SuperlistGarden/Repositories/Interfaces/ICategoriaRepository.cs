using SuperlistGarden.Models;

namespace SuperlistGarden.Repositories.Interfaces
{
	public interface ICategoriaRepository
	{
		IEnumerable<Categoria> Categorias { get; }
	}
}
