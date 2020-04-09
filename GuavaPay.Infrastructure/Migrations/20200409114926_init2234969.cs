using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuavaPay.Infrastructure.Migrations
{
    public partial class init2234969 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    DocumentSeries = table.Column<string>(nullable: true),
                    DocumentNumber = table.Column<string>(nullable: true),
                    DocumentProdDate = table.Column<DateTime>(nullable: false),
                    DocumentEndDate = table.Column<DateTime>(nullable: false),
                    DocumentProdCity = table.Column<string>(nullable: true),
                    DocumentProdCountry = table.Column<string>(nullable: true),
                    ReceiverPhone = table.Column<string>(nullable: true),
                    SenderPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    CountryCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GuavaUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuavaUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Limits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfDay = table.Column<int>(nullable: false),
                    AmountLimit = table.Column<decimal>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Limits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsStatic = table.Column<bool>(nullable: false),
                    AmountFrom = table.Column<decimal>(nullable: false),
                    AmountTo = table.Column<decimal>(nullable: false),
                    ComissionAmount = table.Column<decimal>(nullable: false),
                    IsPercent = table.Column<bool>(nullable: false),
                    ComissionPercent = table.Column<decimal>(nullable: false),
                    IsGuava = table.Column<bool>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    ToSender = table.Column<bool>(nullable: false),
                    AgentComissionAmount = table.Column<decimal>(nullable: false),
                    AgentComissionPercent = table.Column<decimal>(nullable: false),
                    ToCountryId = table.Column<int>(nullable: false),
                    FromCountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comissions_Countries_FromCountryId",
                        column: x => x.FromCountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comissions_Countries_ToCountryId",
                        column: x => x.ToCountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Currencies_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientLimits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsSender = table.Column<bool>(nullable: false),
                    UsedAmount = table.Column<decimal>(nullable: false),
                    NextRenewalDate = table.Column<DateTime>(nullable: false),
                    LimitId = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientLimits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientLimits_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientLimits_Limits_LimitId",
                        column: x => x.LimitId,
                        principalTable: "Limits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    AllowSend = table.Column<bool>(nullable: false),
                    AllowReceive = table.Column<bool>(nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agents_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryCurrencyTransfers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCurrencyTransfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountryCurrencyTransfers_Countries_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryCurrencyTransfers_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyRates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellRate = table.Column<decimal>(nullable: false),
                    BuyRate = table.Column<decimal>(nullable: false),
                    RateDateTime = table.Column<DateTime>(nullable: false),
                    FromCurrencyId = table.Column<int>(nullable: false),
                    ToCurrencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrencyRates_Currencies_FromCurrencyId",
                        column: x => x.FromCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CurrencyRates_Currencies_ToCurrencyId",
                        column: x => x.ToCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(nullable: true),
                    AvailableAmount = table.Column<decimal>(nullable: false),
                    BlockedAmount = table.Column<decimal>(nullable: false),
                    AccountTypeId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    AgentId = table.Column<int>(nullable: false),
                    AccountStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountStatuses_AccountStatusId",
                        column: x => x.AccountStatusId,
                        principalTable: "AccountStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentComissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentId = table.Column<int>(nullable: false),
                    ComissionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentComissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentComissions_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgentComissions_Comissions_ComissionId",
                        column: x => x.ComissionId,
                        principalTable: "Comissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentCountries",
                columns: table => new
                {
                    AgentId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentCountries", x => x.AgentId);
                    table.ForeignKey(
                        name: "FK_AgentCountries_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgentCountries_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentIps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IP = table.Column<string>(nullable: true),
                    AgentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentIps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentIps_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentLimits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentId = table.Column<int>(nullable: false),
                    LimitId = table.Column<int>(nullable: false),
                    UsedAmount = table.Column<decimal>(nullable: false),
                    NextRenewalDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentLimits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentLimits_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgentLimits_Limits_LimitId",
                        column: x => x.LimitId,
                        principalTable: "Limits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentMandatoryFields",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameMandatory = table.Column<bool>(nullable: false),
                    SurnameMandatory = table.Column<bool>(nullable: false),
                    LastnameMandatory = table.Column<bool>(nullable: false),
                    BirthdayMandatory = table.Column<bool>(nullable: false),
                    DocumentNumberMandatory = table.Column<bool>(nullable: false),
                    DocumentSeriesMandatory = table.Column<bool>(nullable: false),
                    DocumentProdDateMandatory = table.Column<bool>(nullable: false),
                    DocumentEndDateMandatory = table.Column<bool>(nullable: false),
                    DocumentProdCityMandatory = table.Column<bool>(nullable: false),
                    DoumentProdCountryMandatory = table.Column<bool>(nullable: false),
                    AgentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentMandatoryFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentMandatoryFields_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    AgentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentUsers_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryLimits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsedAmount = table.Column<decimal>(nullable: false),
                    NextRenewalDate = table.Column<DateTime>(nullable: false),
                    FromCountryId = table.Column<int>(nullable: false),
                    ToCountryId = table.Column<int>(nullable: false),
                    LimitId = table.Column<int>(nullable: false),
                    AgentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryLimits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountryLimits_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryLimits_Countries_FromCountryId",
                        column: x => x.FromCountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryLimits_Limits_LimitId",
                        column: x => x.LimitId,
                        principalTable: "Limits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryLimits_Countries_ToCountryId",
                        column: x => x.ToCountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsDelivered = table.Column<bool>(nullable: false),
                    ConversionAmount = table.Column<decimal>(nullable: false),
                    RNN = table.Column<string>(nullable: true),
                    AgentReference = table.Column<string>(nullable: true),
                    AgentCode = table.Column<string>(nullable: true),
                    AgentMessage = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    RC = table.Column<int>(nullable: false),
                    FromAgentId = table.Column<int>(nullable: false),
                    ToAgentId = table.Column<int>(nullable: true),
                    FromCityId = table.Column<int>(nullable: false),
                    ToCityId = table.Column<int>(nullable: false),
                    FromClientId = table.Column<int>(nullable: false),
                    ToClientId = table.Column<int>(nullable: false),
                    SenderCurrencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionRequests_Agents_FromAgentId",
                        column: x => x.FromAgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionRequests_Clients_FromAgentId",
                        column: x => x.FromAgentId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionRequests_Cities_FromCityId",
                        column: x => x.FromCityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionRequests_Currencies_SenderCurrencyId",
                        column: x => x.SenderCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionRequests_Agents_ToAgentId",
                        column: x => x.ToAgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionRequests_Cities_ToCityId",
                        column: x => x.ToCityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionRequests_Clients_ToClientId",
                        column: x => x.ToClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    SourceAccountId = table.Column<int>(nullable: false),
                    TargetAccountId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    TransactionAmount = table.Column<decimal>(nullable: false),
                    ComisionAmount = table.Column<decimal>(nullable: false),
                    TransactionType = table.Column<string>(nullable: true),
                    TransactionDescription = table.Column<string>(nullable: true),
                    TransactionRequestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Accounts_SourceAccountId",
                        column: x => x.SourceAccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Accounts_TargetAccountId",
                        column: x => x.TargetAccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_TransactionRequests_TransactionRequestId",
                        column: x => x.TransactionRequestId,
                        principalTable: "TransactionRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountStatusId",
                table: "Accounts",
                column: "AccountStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountTypeId",
                table: "Accounts",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AgentId",
                table: "Accounts",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CurrencyId",
                table: "Accounts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentComissions_AgentId",
                table: "AgentComissions",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentComissions_ComissionId",
                table: "AgentComissions",
                column: "ComissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentCountries_CountryId",
                table: "AgentCountries",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentIps_AgentId",
                table: "AgentIps",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentLimits_AgentId",
                table: "AgentLimits",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentLimits_LimitId",
                table: "AgentLimits",
                column: "LimitId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentMandatoryFields_AgentId",
                table: "AgentMandatoryFields",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Agents_CityId",
                table: "Agents",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentUsers_AgentId",
                table: "AgentUsers",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLimits_ClientId",
                table: "ClientLimits",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLimits_LimitId",
                table: "ClientLimits",
                column: "LimitId");

            migrationBuilder.CreateIndex(
                name: "IX_Comissions_FromCountryId",
                table: "Comissions",
                column: "FromCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comissions_ToCountryId",
                table: "Comissions",
                column: "ToCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryCurrencyTransfers_CurrencyId",
                table: "CountryCurrencyTransfers",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryLimits_AgentId",
                table: "CountryLimits",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryLimits_FromCountryId",
                table: "CountryLimits",
                column: "FromCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryLimits_LimitId",
                table: "CountryLimits",
                column: "LimitId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryLimits_ToCountryId",
                table: "CountryLimits",
                column: "ToCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_CountryId",
                table: "Currencies",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyRates_FromCurrencyId",
                table: "CurrencyRates",
                column: "FromCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyRates_ToCurrencyId",
                table: "CurrencyRates",
                column: "ToCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CurrencyId",
                table: "Transaction",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_SourceAccountId",
                table: "Transaction",
                column: "SourceAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_TargetAccountId",
                table: "Transaction",
                column: "TargetAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_TransactionRequestId",
                table: "Transaction",
                column: "TransactionRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRequests_FromAgentId",
                table: "TransactionRequests",
                column: "FromAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRequests_FromCityId",
                table: "TransactionRequests",
                column: "FromCityId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRequests_SenderCurrencyId",
                table: "TransactionRequests",
                column: "SenderCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRequests_ToAgentId",
                table: "TransactionRequests",
                column: "ToAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRequests_ToCityId",
                table: "TransactionRequests",
                column: "ToCityId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRequests_ToClientId",
                table: "TransactionRequests",
                column: "ToClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentComissions");

            migrationBuilder.DropTable(
                name: "AgentCountries");

            migrationBuilder.DropTable(
                name: "AgentIps");

            migrationBuilder.DropTable(
                name: "AgentLimits");

            migrationBuilder.DropTable(
                name: "AgentMandatoryFields");

            migrationBuilder.DropTable(
                name: "AgentUsers");

            migrationBuilder.DropTable(
                name: "ClientLimits");

            migrationBuilder.DropTable(
                name: "CountryCurrencyTransfers");

            migrationBuilder.DropTable(
                name: "CountryLimits");

            migrationBuilder.DropTable(
                name: "CurrencyRates");

            migrationBuilder.DropTable(
                name: "GuavaUsers");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "TransactionStatuses");

            migrationBuilder.DropTable(
                name: "Comissions");

            migrationBuilder.DropTable(
                name: "Limits");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "TransactionRequests");

            migrationBuilder.DropTable(
                name: "AccountStatuses");

            migrationBuilder.DropTable(
                name: "AccountType");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
