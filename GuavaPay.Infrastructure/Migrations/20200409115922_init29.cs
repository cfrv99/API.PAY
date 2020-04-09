using Microsoft.EntityFrameworkCore.Migrations;

namespace GuavaPay.Infrastructure.Migrations
{
    public partial class init29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRates_Currencies_FromCurrencyId",
                table: "CurrencyRates");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRates_Currencies_ToCurrencyId",
                table: "CurrencyRates");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRates_Currencies_FromCurrencyId",
                table: "CurrencyRates",
                column: "FromCurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRates_Currencies_ToCurrencyId",
                table: "CurrencyRates",
                column: "ToCurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRates_Currencies_FromCurrencyId",
                table: "CurrencyRates");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRates_Currencies_ToCurrencyId",
                table: "CurrencyRates");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRates_Currencies_FromCurrencyId",
                table: "CurrencyRates",
                column: "FromCurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRates_Currencies_ToCurrencyId",
                table: "CurrencyRates",
                column: "ToCurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");
        }
    }
}
