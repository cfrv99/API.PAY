using Microsoft.EntityFrameworkCore.Migrations;

namespace GuavaPay.Infrastructure.Migrations
{
    public partial class iniddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.CreateIndex(
                name: "IX_CountryCurrencyTransfers_CountryId",
                table: "CountryCurrencyTransfers",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CountryId",
                table: "CountryCurrencyTransfers",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CountryId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.DropIndex(
                name: "IX_CountryCurrencyTransfers_CountryId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                table: "CountryCurrencyTransfers",
                column: "CurrencyId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
