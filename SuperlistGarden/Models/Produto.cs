using System.ComponentModel.DataAnnotations;

namespace SuperlistGarden.Models
{
	public class Produto
	{
		public int ProdutoId { get; set; }
		public string Nome { get; set; }
		public string Quantidade { get; set; }
		public bool IsProdutoDestaque { get; set; }
		public int CategoriaId { get; set; }
		public Categoria Categoria { get; set; }
	}
}
