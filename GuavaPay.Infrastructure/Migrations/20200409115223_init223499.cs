using Microsoft.EntityFrameworkCore.Migrations;

namespace GuavaPay.Infrastructure.Migrations
{
    public partial class init223499 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
