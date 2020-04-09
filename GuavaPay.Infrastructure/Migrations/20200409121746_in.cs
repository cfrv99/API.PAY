using Microsoft.EntityFrameworkCore.Migrations;

namespace GuavaPay.Infrastructure.Migrations
{
    public partial class @in : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CountryId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRates_Currencies_FromCurrencyId",
                table: "CurrencyRates");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRates_Currencies_ToCurrencyId",
                table: "CurrencyRates");

            migrationBuilder.DropIndex(
                name: "IX_CountryCurrencyTransfers_CountryId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "CurrencyRates",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId1",
                table: "CurrencyRates",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyRates_CurrencyId",
                table: "CurrencyRates",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyRates_CurrencyId1",
                table: "CurrencyRates",
                column: "CurrencyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                table: "CountryCurrencyTransfers",
                column: "CurrencyId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRates_Currencies_CurrencyId",
                table: "CurrencyRates",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRates_Currencies_CurrencyId1",
                table: "CurrencyRates",
                column: "CurrencyId1",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRates_Currencies_FromCurrencyId",
                table: "CurrencyRates",
                column: "FromCurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete:ReferentialAction.NoAction
                );

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRates_Currencies_ToCurrencyId",
                table: "CurrencyRates",
                column: "ToCurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete:ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                table: "CountryCurrencyTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRates_Currencies_CurrencyId",
                table: "CurrencyRates");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRates_Currencies_CurrencyId1",
                table: "CurrencyRates");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRates_Currencies_FromCurrencyId",
                table: "CurrencyRates");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRates_Currencies_ToCurrencyId",
                table: "CurrencyRates");

            migrationBuilder.DropIndex(
                name: "IX_CurrencyRates_CurrencyId",
                table: "CurrencyRates");

            migrationBuilder.DropIndex(
                name: "IX_CurrencyRates_CurrencyId1",
                table: "CurrencyRates");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "CurrencyRates");

            migrationBuilder.DropColumn(
                name: "CurrencyId1",
                table: "CurrencyRates");

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRates_Currencies_ToCurrencyId",
                table: "CurrencyRates",
                column: "ToCurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
