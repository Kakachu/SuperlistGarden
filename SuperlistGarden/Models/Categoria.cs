﻿using System.ComponentModel.DataAnnotations;

namespace SuperlistGarden.Models
{
	public class Categoria
	{
		public int CategoriaId { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public string ImagemUrl { get; set; }
		public List<Produto> Produtos { get; set; }
	}
}
