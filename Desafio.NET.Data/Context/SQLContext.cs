using Desafio.NET.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio.NET.Data.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Chave> Chaves { get; set; }
        public DbSet<Pagador> Pagadores { get; set; }
        public DbSet<Recebedor> Recebedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SQLContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
