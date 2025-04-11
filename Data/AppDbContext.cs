using Microsoft.EntityFrameworkCore;
using Projeto_BarberShop_Code.Models;
using Projeto_BarberShop_Code.Models.Enum;

namespace Projeto_BarberShop_Code.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use essa linha se NÃO estiver injetando o contexto por DI no Program.cs
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("sua-string-de-conexao");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Salva o enum como string (opcional)
            modelBuilder.Entity<UsuarioModel>()
                .Property(u => u.TipoUsuario)
                .HasConversion<string>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
