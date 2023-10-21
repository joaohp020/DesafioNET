using Desafio.NET.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.NET.Data.Mappings
{
    public class ChaveMapping : IEntityTypeConfiguration<Chave>
    {
        public void Configure(EntityTypeBuilder<Chave> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("varchar(1000)");
            
            builder.ToTable("Chave");
        }
    }
}
