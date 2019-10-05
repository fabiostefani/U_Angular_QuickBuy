using fabiostefani.io.QuickBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.QuickBuy.Repositorio.Config
{
    public class ItemPedidoConfig : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.ToTable("itenspedido");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("idpedido")
                .IsRequired();

            builder.Property(x => x.ProdutoId)
                .HasColumnName("idproduto")
                .IsRequired();

            builder.Property(x => x.PedidoId)
                .HasColumnName("idpedido")
                .IsRequired();

            builder.Property(x => x.Quantidade)
                .HasColumnName("quantidade")
                .IsRequired();

            builder.HasOne(x => x.Produto)                
                .WithMany()
                .HasForeignKey(x => x.ProdutoId);
        }
    }
}
