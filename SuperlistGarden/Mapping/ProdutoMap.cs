using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperlistGarden.Models;

namespace SuperlistGarden.Mapping
{
	public sealed class ProdutoMap
	{

		public ProdutoMap(EntityTypeBuilder<Produto> builder)
		{
			builder.ToTable("PRODUTOS").HasKey(p => p.ProdutoId);

			builder.Property(p => p.ProdutoId)
				   .HasColumnName("IDPRODUTO")
				   .HasColumnType("INT");

			builder.Property(p => p.Nome)
				   .HasColumnName("NOME")
				   .HasColumnType("VARCHAR(100)")
				   .HasMaxLength(100)
				   .IsRequired();

			builder.Property(p => p.Quantidade)
				   .HasColumnName("QUANTIDADE")
				   .HasColumnType("CHAR(5)")
				   .HasMaxLength(5)
				   .IsRequired();

			builder.Property(p => p.IsProdutoDestaque)
				   .HasColumnName("IS_PRODUTO_DESTAQUE")
				   .HasColumnType("BIT")
				   .IsRequired();

			builder.Property(p => p.CategoriaId)
				   .HasColumnName("ID_CATEGORIA")
				   .HasColumnType("INT")
				   .IsRequired();
		}
	}
}

