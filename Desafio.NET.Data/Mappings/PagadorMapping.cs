using Desafio.NET.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.NET.Data.Mappings
{
    public class PagadorMapping : IEntityTypeConfiguration<Pagador>
    {
        public void Configure(EntityTypeBuilder<Pagador> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(1000)");
            
            builder.ToTable("Pagador");
        }
    }
}
