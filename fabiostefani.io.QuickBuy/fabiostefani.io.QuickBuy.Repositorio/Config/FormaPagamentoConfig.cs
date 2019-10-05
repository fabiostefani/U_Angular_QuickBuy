using fabiostefani.io.QuickBuy.Dominio.ObjetoDeValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fabiostefani.io.QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfig : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.ToTable("formapagamento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("idformapagto")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnName("descricao")
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
