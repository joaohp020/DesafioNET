using Desafio.NET.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.NET.Data.Mappings
{
    public class TransacaoMapping : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.DataTransacao)
                .IsRequired()
                .HasColumnType("date");
            
            builder.HasOne(p => p.Pagador)
                .WithMany(p => p.Transacoes)
                .IsRequired();
            
            builder.HasOne(p => p.Recebedor)
                .WithMany(p => p.Transacoes)
                .IsRequired();

            builder.ToTable("Transacoes");
        }
    }
}
