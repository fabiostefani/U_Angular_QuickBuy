using fabiostefani.io.QuickBuy.Dominio.Entidades;
using fabiostefani.io.QuickBuy.Dominio.ObjetoDeValor;
using fabiostefani.io.QuickBuy.Repositorio.Config;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Host = localhost; Port = 5432; Pooling = true; Database = QuickBuy; User Id = postgres; Password = Postgres2019;");            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new ProdutoConfig());
            modelBuilder.ApplyConfiguration(new PedidoConfig());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfig());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfig());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() { Id = 1, Descricao = "Pagamento através do Boleto", Nome = "Boleto" },
                new FormaPagamento() { Id = 2, Descricao = "Pagamento através do Cartão de Crédito", Nome = "Cartão de Crédito" },
                new FormaPagamento() { Id = 3, Descricao = "Pagamento através de Depósito Bancário", Nome = "Depósito bancário" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
