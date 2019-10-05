using fabiostefani.io.QuickBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.QuickBuy.Repositorio.Config
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produtos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("idproduto")
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Descricao)
                .HasColumnName("descricao")
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(x => x.Preco)
                .HasColumnName("preco")
                .IsRequired();
           
        }
    }
}
