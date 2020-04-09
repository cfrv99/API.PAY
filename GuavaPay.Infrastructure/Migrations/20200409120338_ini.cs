using Microsoft.EntityFrameworkCore.Migrations;

namespace GuavaPay.Infrastructure.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                table: "CountryCurrencyTransfers",
                column: "CurrencyId",
                principalTable: "Countries",
                principalColumn: "Id");

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
                name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                table: "CountryCurrencyTransfers",
                column: "CurrencyId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
