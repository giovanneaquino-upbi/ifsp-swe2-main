// Giovanne CB 3026591 / Ricardo CB3025543
// Projeto: Gerenciador de produtos
// CBTSWE2 - Trabalho Prático 03

using Microsoft.EntityFrameworkCore;
using GerProTP3.Models;

namespace GerProTP3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações adicionais do modelo
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Description).IsRequired().HasMaxLength(500);
                entity.Property(p => p.Price).HasColumnType("decimal(18,2)");
                entity.Property(p => p.StockQuantity).IsRequired();
                entity.Property(p => p.CreatedAt).IsRequired();
            });
        }
    }
}