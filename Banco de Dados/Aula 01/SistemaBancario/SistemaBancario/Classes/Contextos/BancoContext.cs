using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Entidades;

namespace SistemaBancario.Classes.Contextos
{
    internal class BancoContext : DbContext
    {
        //Propriedades
        /// <summary>
        /// Representa a tabela de contas bancárias no banco de dados
        /// DbSet permite realizar operações CRUD
        /// </summary>
        public DbSet<Banco> Contas { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqlocaldb;Database=BancoDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banco>
                (
                entity =>
                {
                    entity.HasKey(e => e.Id);
                    entity.Property(e => e.NumeroConta).IsRequired();
                    entity.Property(e => e.Titular).IsRequired().HasMaxLength(50);
                    entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2");
                }
                );
        }
    }
}
