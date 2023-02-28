using Microsoft.AspNetCore.Mvc;
using SuperlistGarden.Context;
using SuperlistGarden.Repositories.Interfaces;

namespace SuperlistGarden.Controllers
{
	public class CategoriaController : Controller
	{
		private readonly AppDbContext _context;
		private readonly ICategoriaRepository _repository;

		public CategoriaController(AppDbContext context, ICategoriaRepository repository)
		{
			_context = context;
			_repository = repository;
		}

		public IActionResult ViewItens()
		{
			var categorias = _repository.Categorias.ToList();
			return View(categorias);
		}
	}
}