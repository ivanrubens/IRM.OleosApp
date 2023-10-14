using IRM.OleosApp.Core.Entities;
using System.Data.Entity;

namespace IRM.OleosApp.Api.Data
{
    public class OleoAppDBContext : DbContext
    {
        public OleoAppDBContext() : base("OleoAppDBConnectionString")
        {
            //Database.SetInitializer<OleoAppDBContext>(new CreateDatabaseIfNotExists<OleoAppDBContext>());
            Database.SetInitializer(new OleoAppDBInitializer());
        }

        public DbSet<TipoProduto> TiposProduto { get; set; }
        public DbSet<UnidadeMedida> UnidadesMedida { get; set; }
        public DbSet<Organizacao> Organizacoes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Kit> Kits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("OleosApp");

            modelBuilder
               .Properties()
               .Where(p => p.PropertyType.Name == "String")
               .Configure(p => p.HasMaxLength(100));

            modelBuilder.Entity<TipoProduto>()
                .ToTable("tipo_produto")
                .HasKey(s => s.Id)
                .Property(p => p.Nome).IsRequired();

            modelBuilder.Entity<TipoProduto>()
                .Property(x => x.Tipo).IsRequired().HasMaxLength(30);

            modelBuilder.Entity<UnidadeMedida>()
                .ToTable("unidade_medida")
                .HasKey(s => s.Id)
                .Property(p => p.Nome).IsRequired();

            modelBuilder.Entity<Organizacao>()
                .ToTable("organizacao")
                .HasKey(s => s.Id)
                .Property(p => p.Nome).IsRequired();


            modelBuilder.Entity<Produto>()
                .ToTable("produto")
                .HasKey(s => s.Id)
                .Property(p => p.Nome).IsRequired();

            modelBuilder.Entity<Kit>()
                .ToTable("kit")
                .HasKey(s => s.Id)
                .Property(p => p.Nome).IsRequired();



        }


    }
}
