using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SonhoSemijoiasBusiness.Models;

namespace SonhoSemijoiasDataBase.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Quantidade)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.Titulo)
                .IsRequired()
                .HasColumnType("varchar(80)");

            builder.Property(p => p.Preco)
                .IsRequired()
                .HasColumnType("double");

            builder.Property(p => p.Ativo)
                .IsRequired()
                .HasColumnType("tinyint(1)");

            builder.Property(p => p.DataCadastro)
                .IsRequired()
                .HasColumnType("datetime");

        }
    }
}
