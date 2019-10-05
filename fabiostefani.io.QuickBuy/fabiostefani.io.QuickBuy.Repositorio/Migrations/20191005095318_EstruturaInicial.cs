using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace fabiostefani.io.QuickBuy.Repositorio.Migrations
{
    public partial class EstruturaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "formapagamento",
                columns: table => new
                {
                    idformapagto = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(maxLength: 100, nullable: false),
                    descricao = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formapagamento", x => x.idformapagto);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    idproduto = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(maxLength: 100, nullable: false),
                    descricao = table.Column<string>(maxLength: 1000, nullable: false),
                    preco = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.idproduto);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    idusuario = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    email = table.Column<string>(maxLength: 100, nullable: false),
                    senha = table.Column<string>(maxLength: 400, nullable: false),
                    nome = table.Column<string>(maxLength: 200, nullable: false),
                    sobrenome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.idusuario);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    idpedido = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    datapedido = table.Column<DateTime>(nullable: false),
                    idusuario = table.Column<int>(nullable: false),
                    dataprevistaentrega = table.Column<DateTime>(nullable: false),
                    cep = table.Column<string>(maxLength: 10, nullable: false),
                    estado = table.Column<string>(maxLength: 2, nullable: false),
                    cidade = table.Column<string>(maxLength: 100, nullable: false),
                    endereco = table.Column<string>(maxLength: 1000, nullable: false),
                    numeroendereco = table.Column<int>(nullable: false),
                    idformapagto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.idpedido);
                    table.ForeignKey(
                        name: "FK_pedidos_formapagamento_idformapagto",
                        column: x => x.idformapagto,
                        principalTable: "formapagamento",
                        principalColumn: "idformapagto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pedidos_usuarios_idusuario",
                        column: x => x.idusuario,
                        principalTable: "usuarios",
                        principalColumn: "idusuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "itenspedido",
                columns: table => new
                {
                    idpedido = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idproduto = table.Column<int>(nullable: false),
                    quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itenspedido", x => x.idpedido);
                    table.ForeignKey(
                        name: "FK_itenspedido_pedidos_idpedido",
                        column: x => x.idpedido,
                        principalTable: "pedidos",
                        principalColumn: "idpedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itenspedido_produtos_idproduto",
                        column: x => x.idproduto,
                        principalTable: "produtos",
                        principalColumn: "idproduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_itenspedido_idpedido",
                table: "itenspedido",
                column: "idpedido");

            migrationBuilder.CreateIndex(
                name: "IX_itenspedido_idproduto",
                table: "itenspedido",
                column: "idproduto");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_idformapagto",
                table: "pedidos",
                column: "idformapagto");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_idusuario",
                table: "pedidos",
                column: "idusuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itenspedido");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "formapagamento");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
