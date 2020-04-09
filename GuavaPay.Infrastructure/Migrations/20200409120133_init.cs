using Microsoft.EntityFrameworkCore.Migrations;

namespace GuavaPay.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                table: "CountryCurrencyTransfers",
                column: "CurrencyId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                table: "CountryCurrencyTransfers",
                column: "CurrencyId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
