using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SonhoSemijoiasBusiness.Models;

namespace SonhoSemijoiasDataBase.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Titulo)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Ativa)
                .IsRequired()
                .HasColumnType("tinyint(1)");

        }
    }
}
