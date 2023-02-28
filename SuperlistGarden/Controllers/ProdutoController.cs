using Microsoft.AspNetCore.Mvc;
using SuperlistGarden.Context;
using SuperlistGarden.Repositories.Interfaces;

namespace SuperlistGarden.Controllers
{
	public class ProdutoController : Controller
	{
		private readonly AppDbContext _context;
		private readonly IProdutoRepository _produtoRepository;

		public ProdutoController(AppDbContext context, IProdutoRepository produtoRepository)
		{
			_context = context;
			_produtoRepository = produtoRepository;
		}

		public IActionResult ViewItens()
		{
			var produtos = _produtoRepository.Produtos.ToList();
			return View(produtos);
		}
	}
}
