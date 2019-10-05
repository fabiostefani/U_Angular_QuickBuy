using fabiostefani.io.QuickBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.QuickBuy.Repositorio.Config
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("idusuario")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnName("email")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Senha)
                .HasColumnName("senha")
                .IsRequired()
                .HasMaxLength(400);

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.SobreNome)
                .HasColumnName("sobrenome")
                .IsRequired()
                .HasMaxLength(50);

            builder.HasMany(x => x.Pedidos)
                .WithOne(x => x.Usuario)
                .HasForeignKey(x => x.UsuarioId);


        }
    }
}
