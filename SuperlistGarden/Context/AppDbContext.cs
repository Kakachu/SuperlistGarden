using Microsoft.EntityFrameworkCore;
using SuperlistGarden.Mapping;
using SuperlistGarden.Models;

namespace SuperlistGarden.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<Categoria> Categorias { get; set; }
		public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //removendo comportamento cascade delete
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                                .SelectMany(t => t.GetForeignKeys())
                                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            new CategoriaMap(modelBuilder.Entity<Categoria>());
            new ProdutoMap(modelBuilder.Entity<Produto>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
