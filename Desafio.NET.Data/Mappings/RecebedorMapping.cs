using Desafio.NET.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.NET.Data.Mappings
{
    public class RecebedorMapping : IEntityTypeConfiguration<Recebedor>
    {
        public void Configure(EntityTypeBuilder<Recebedor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(1000)");
            
            builder.ToTable("Recebedor");
        }
    }
}
