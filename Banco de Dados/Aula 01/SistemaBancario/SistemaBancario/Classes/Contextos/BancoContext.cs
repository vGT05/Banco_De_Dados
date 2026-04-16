using System;
using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Entidades;
using Microsoft.Data.SqlClient;

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
            var sqlConnString = @"Server=(localdb)\MSSQLLocalDB;Database=BancoDB;Trusted_Connection=True;";

            try
            {
                // Testa se a instância LocalDB responde antes de configurar o EF para usá-la
                using var testConn = new SqlConnection(sqlConnString);
                testConn.Open();
                testConn.Close();

                optionsBuilder.UseSqlServer(sqlConnString);
            }
            catch (Exception)
            {
                // Fallback para SQLite local (útil para desenvolvimento quando LocalDB não está disponível)
                // Requer o pacote: Microsoft.EntityFrameworkCore.Sqlite
                var sqliteConn = "Data Source=BancoDB.db";
                optionsBuilder.UseSqlite(sqliteConn);
            }
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
                    entity.Property(e => e.Saldo).HasColumnType("decimal(18,2)");
                }
                );
        }
    }
}
