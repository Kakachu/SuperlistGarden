using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperlistGarden.Models;

namespace SuperlistGarden.Mapping
{
	public sealed class CategoriaMap
	{
		public CategoriaMap(EntityTypeBuilder<Categoria> builder)
		{
			builder.ToTable("CATEGORIAS").HasKey(p => p.CategoriaId);

			builder.Property(p => p.CategoriaId)
				   .HasColumnName("IDCATEGORIA")
				   .HasColumnType("INT");

			builder.Property(p => p.Nome)
				   .HasColumnName("NOME")
				   .HasColumnType("VARCHAR(100)")
				   .HasMaxLength(100)
				   .IsRequired();

			builder.Property(p => p.Descricao)
				   .HasColumnName("DESCRICAO")
				   .HasColumnType("VARCHAR(250)")
				   .HasMaxLength(250);

			builder.Property(p => p.ImagemUrl)
				   .HasColumnName("IMAGEM_URL")
				   .HasColumnType("VARCHAR(200)")
				   .HasMaxLength(200);

		}
	}
}
