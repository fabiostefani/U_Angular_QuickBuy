using fabiostefani.io.QuickBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.QuickBuy.Repositorio.Config
{
    public class PedidoConfig : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("pedidos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("idpedido")
                .IsRequired();

            builder.Property(x => x.DataPedido)
                .HasColumnName("datapedido")
                .IsRequired();

            builder.Property(x => x.UsuarioId)
                .HasColumnName("idusuario")
                .IsRequired();

            builder.Property(x => x.DataPrevisaoEntrega)
                .HasColumnName("dataprevistaentrega")
                .IsRequired();

            builder.Property(x => x.Cep)
                .HasColumnName("cep")
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(x => x.Estado)
                .HasColumnName("estado")
                .IsRequired()
                .HasMaxLength(2);

            builder.Property(x => x.Cidade)
                .HasColumnName("cidade")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.EnderecoCompleto)
                .HasColumnName("endereco")
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(x => x.NumeroEndereco)
                .HasColumnName("numeroendereco")
                .IsRequired();

            builder.Property(x => x.FormaPagamentoId)
                .HasColumnName("idformapagto")
                .IsRequired();


            //public FormaPagamento FormaPagamento { get; set; }

            builder.HasOne(x => x.FormaPagamento)
                .WithMany()
                .HasForeignKey(x => x.FormaPagamentoId);

            builder.HasMany(x => x.ItensPedido)
                .WithOne(x => x.Pedido)
                .HasForeignKey(x => x.PedidoId);

            //public ICollection<ItemPedido> ItensPedido { get; set; }
        }
    }
}
