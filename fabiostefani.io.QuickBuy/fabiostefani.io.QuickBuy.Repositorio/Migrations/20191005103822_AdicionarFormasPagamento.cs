using Microsoft.EntityFrameworkCore.Migrations;

namespace fabiostefani.io.QuickBuy.Repositorio.Migrations
{
    public partial class AdicionarFormasPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "formapagamento",
                columns: new[] { "idformapagto", "descricao", "nome" },
                values: new object[,]
                {
                    { 1, "Pagamento através do Boleto", "Boleto" },
                    { 2, "Pagamento através do Cartão de Crédito", "Cartão de Crédito" },
                    { 3, "Pagamento através de Depósito Bancário", "Depósito bancário" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "formapagamento",
                keyColumn: "idformapagto",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "formapagamento",
                keyColumn: "idformapagto",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "formapagamento",
                keyColumn: "idformapagto",
                keyValue: 3);
        }
    }
}
