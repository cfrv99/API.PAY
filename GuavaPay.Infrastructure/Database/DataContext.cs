using GuavaPay.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuavaPay.Infrastructure.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountStatus> AccountStatuses { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<AgentComission> AgentComissions { get; set; }
        public DbSet<AgentCountry> AgentCountries { get; set; }
        public DbSet<AgentIp> AgentIps { get; set; }
        public DbSet<AgentLimit> AgentLimits { get; set; }
        public DbSet<AgentMandatoryField> AgentMandatoryFields { get; set; }
        public DbSet<AgentUser> AgentUsers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientLimit> ClientLimits { get; set; }
        public DbSet<Comission> Comissions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryCurrencyTransfer> CountryCurrencyTransfers { get; set; }
        public DbSet<CountryLimit> CountryLimits { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyRate> CurrencyRates { get; set; }
        public DbSet<GuavaUser> GuavaUsers { get; set; }
        public DbSet<Limit> Limits { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<TransactionRequest> TransactionRequests { get; set; }
        public DbSet<TransactionStatus> TransactionStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comission>()
                .HasOne(c => c.ToCountry)
                .WithMany(c => c.ComissionsTo)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Comission>()
                   .HasOne(c => c.FromCountry)
                    .WithMany(a => a.ComissionsFrom)
                    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CurrencyRate>()
                .HasOne(c => c.ToCurrency)
                .WithMany(c => c.ToCurrencyRates)
                .OnDelete(DeleteBehavior.NoAction);

            

            modelBuilder.Entity<CurrencyRate>()
            .HasOne(c => c.FromCurrency)
            .WithMany(a => a.FromCurrencyRates)
            .OnDelete(DeleteBehavior.NoAction);


            /*foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }*/

            modelBuilder.Entity<Account>().HasKey(i => i.Id);
            modelBuilder.Entity<Account>().HasOne(i => i.AccountType).WithMany(i => i.Accounts).HasForeignKey(i => i.AccountTypeId);
            modelBuilder.Entity<Account>().HasOne(i => i.AccountStatus).WithMany(i => i.Accounts).HasForeignKey(i => i.AccountStatusId);
            modelBuilder.Entity<Account>().HasOne(i => i.Agent).WithMany(i => i.Accounts).HasForeignKey(i => i.AgentId);
            modelBuilder.Entity<Account>().HasOne(i => i.Currency).WithMany(i => i.Accounts).HasForeignKey(i => i.CurrencyId);

            modelBuilder.Entity<AccountStatus>().HasKey(i => i.Id);
            modelBuilder.Entity<AccountStatus>().HasMany(i => i.Accounts).WithOne(i => i.AccountStatus).HasForeignKey(i => i.AccountStatusId);
            modelBuilder.Entity<AccountType>().HasKey(i => i.Id);
            modelBuilder.Entity<AccountType>().HasMany(i => i.Accounts).WithOne(i => i.AccountType).HasForeignKey(i => i.AccountTypeId);

            modelBuilder.Entity<Agent>().HasKey(i => i.Id);
            modelBuilder.Entity<Agent>().HasOne(i => i.City).WithMany(i => i.Agents).HasForeignKey(i => i.CityId);
            modelBuilder.Entity<Agent>().HasMany(i => i.Accounts).WithOne(i => i.Agent).HasForeignKey(i => i.AgentId);
            modelBuilder.Entity<Agent>().HasMany(i => i.AgentIps).WithOne(i => i.Agent).HasForeignKey(i => i.AgentId);
            modelBuilder.Entity<Agent>().HasMany(i => i.AgentLimits).WithOne(i => i.Agent).HasForeignKey(i => i.AgentId);
            modelBuilder.Entity<Agent>().HasMany(i => i.AgentCountries).WithOne(i => i.Agent).HasForeignKey(i => i.AgentId);
            modelBuilder.Entity<Agent>().HasMany(i => i.AgentMandatoryFields).WithOne(i => i.Agent).HasForeignKey(i => i.AgentId);
            modelBuilder.Entity<Agent>().HasMany(i => i.AgentUsers).WithOne(i => i.Agent).HasForeignKey(i => i.AgentId);

            modelBuilder.Entity<AgentComission>().HasKey(i => i.Id);
            modelBuilder.Entity<AgentComission>().HasOne(i => i.Agent).WithMany(i => i.AgentComissions).HasForeignKey(i => i.AgentId);
            modelBuilder.Entity<AgentComission>().HasOne(i => i.Comission).WithMany(i => i.AgentComissions).HasForeignKey(i => i.AgentId);

            modelBuilder.Entity<AgentCountry>().HasKey(i => i.AgentId);
            modelBuilder.Entity<AgentCountry>().HasOne(i => i.Agent).WithMany(i => i.AgentCountries).HasForeignKey(i => i.AgentId);
            modelBuilder.Entity<AgentCountry>().HasOne(i => i.Country).WithMany(i => i.AgentCountries).HasForeignKey(i => i.CountryId);

            modelBuilder.Entity<AgentIp>().HasKey(i => i.Id);
            modelBuilder.Entity<AgentIp>().HasOne(i => i.Agent).WithMany(i => i.AgentIps).HasForeignKey(i => i.AgentId);

            modelBuilder.Entity<AgentLimit>().HasKey(i => i.Id);
            modelBuilder.Entity<AgentLimit>().HasOne(i => i.Agent).WithMany(i => i.AgentLimits).HasForeignKey(i => i.AgentId);
            modelBuilder.Entity<AgentLimit>().HasOne(i => i.Limit).WithMany(i => i.AgentLimits).HasForeignKey(i => i.LimitId);

            modelBuilder.Entity<AgentMandatoryField>().HasKey(i => i.Id);
            modelBuilder.Entity<AgentMandatoryField>().HasOne(i => i.Agent).WithMany(i => i.AgentMandatoryFields).HasForeignKey(i => i.AgentId);

            modelBuilder.Entity<AgentUser>().HasKey(i => i.Id);
            modelBuilder.Entity<AgentUser>().HasOne(i => i.Agent).WithMany(i => i.AgentUsers).HasForeignKey(i => i.AgentId);

            modelBuilder.Entity<City>().HasKey(i => i.Id);
            modelBuilder.Entity<City>().HasOne(i => i.Country).WithMany(i => i.Cities).HasForeignKey(i => i.CountryId);
            modelBuilder.Entity<City>().HasMany(i => i.Agents).WithOne(i => i.City).HasForeignKey(i => i.CityId);

            modelBuilder.Entity<Client>().HasKey(i => i.Id);
            modelBuilder.Entity<Client>().HasMany(i => i.ClientLimits).WithOne(i => i.Client).HasForeignKey(i => i.ClientId);


            modelBuilder.Entity<ClientLimit>().HasKey(i => i.Id);
            modelBuilder.Entity<ClientLimit>().HasOne(i => i.Client).WithMany(i => i.ClientLimits).HasForeignKey(i => i.ClientId);
            modelBuilder.Entity<ClientLimit>().HasOne(i => i.Limit).WithMany(i => i.ClientLimits).HasForeignKey(i => i.LimitId);

            modelBuilder.Entity<Currency>().HasKey(i => i.Id);
            modelBuilder.Entity<Currency>().HasOne(i => i.Country).WithMany(i => i.Currencies).HasForeignKey(i => i.CountryId);
            modelBuilder.Entity<Currency>().HasMany(i => i.Accounts).WithOne(i => i.Currency).HasForeignKey(i => i.CurrencyId);
            modelBuilder.Entity<Currency>().HasMany(i => i.Transactions).WithOne(i => i.Currency).HasForeignKey(i => i.CurrencyId);
            modelBuilder.Entity<Currency>().HasMany(i => i.FromCurrencyRates).WithOne(i => i.FromCurrency).HasForeignKey(i => i.FromCurrencyId);
            modelBuilder.Entity<Currency>().HasMany(i => i.ToCurrencyRates).WithOne(i => i.ToCurrency).HasForeignKey(i => i.ToCurrencyId);
            modelBuilder.Entity<Currency>().HasMany(i => i.CountryCurrencyTransfers).WithOne(i => i.Currency).HasForeignKey(i => i.CurrencyId);

            modelBuilder.Entity<Comission>().HasKey(i => i.Id);
            modelBuilder.Entity<Comission>().HasOne(i => i.FromCountry).WithMany(i => i.ComissionsFrom).HasForeignKey(i => i.FromCountryId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Comission>().HasOne(i => i.ToCountry).WithMany(i => i.ComissionsTo).HasForeignKey(i => i.ToCountryId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Comission>().HasMany(i => i.AgentComissions).WithOne(i => i.Comission).HasForeignKey(i => i.ComissionId);

            modelBuilder.Entity<Country>().HasKey(i => i.Id);
            modelBuilder.Entity<Country>().HasMany(i => i.ComissionsTo).WithOne(i => i.ToCountry).HasForeignKey(i => i.ToCountryId);
            modelBuilder.Entity<Country>().HasMany(i => i.ComissionsFrom).WithOne(i => i.FromCountry).HasForeignKey(i => i.FromCountryId);
            modelBuilder.Entity<Country>().HasMany(i => i.AgentCountries).WithOne(i => i.Country).HasForeignKey(i => i.CountryId);
            modelBuilder.Entity<Country>().HasMany(i => i.CountryCurrencyTransfers).WithOne(i => i.Country).HasForeignKey(i => i.CountryId);
            modelBuilder.Entity<Country>().HasMany(i => i.Currencies).WithOne(i => i.Country).HasForeignKey(i => i.CountryId);
            modelBuilder.Entity<Country>().HasMany(i => i.FromCountryLimits).WithOne(i => i.FromCountry).HasForeignKey(i => i.FromCountryId);
            modelBuilder.Entity<Country>().HasMany(i => i.ToCountryLimits).WithOne(i => i.ToCountry).HasForeignKey(i => i.ToCountryId);
            modelBuilder.Entity<Country>().HasMany(i => i.Cities).WithOne(i => i.Country).HasForeignKey(i => i.CountryId);

            modelBuilder.Entity<CountryCurrencyTransfer>().HasKey(i => i.Id);
            modelBuilder.Entity<CountryCurrencyTransfer>().HasOne(i => i.Country).WithMany(i => i.CountryCurrencyTransfers).HasForeignKey(i => i.CurrencyId);
            modelBuilder.Entity<CountryCurrencyTransfer>().HasOne(i => i.Currency).WithMany(i => i.CountryCurrencyTransfers).HasForeignKey(i => i.CurrencyId);

            modelBuilder.Entity<CountryLimit>().HasKey(i => i.Id);
            modelBuilder.Entity<CountryLimit>().HasOne(i => i.FromCountry).WithMany(i => i.FromCountryLimits).HasForeignKey(i => i.FromCountryId);
            modelBuilder.Entity<CountryLimit>().HasOne(i => i.ToCountry).WithMany(i => i.ToCountryLimits).HasForeignKey(i => i.ToCountryId);
            modelBuilder.Entity<CountryLimit>().HasOne(i => i.Agent).WithMany(i => i.CountryLimits).HasForeignKey(i => i.AgentId);
            modelBuilder.Entity<CountryLimit>().HasOne(i => i.Limit).WithMany(i => i.CountryLimits).HasForeignKey(i => i.LimitId);

            modelBuilder.Entity<CurrencyRate>().HasKey(i => i.Id);
            modelBuilder.Entity<CurrencyRate>().HasOne(i => i.FromCurrency).WithMany().HasForeignKey(i => i.FromCurrencyId);
            modelBuilder.Entity<CurrencyRate>().HasOne(i => i.ToCurrency).WithMany().HasForeignKey(i => i.ToCurrencyId);

            modelBuilder.Entity<GuavaUser>().HasKey(i => i.Id);

            modelBuilder.Entity<Limit>().HasKey(i => i.Id);
            modelBuilder.Entity<Limit>().HasMany(i => i.AgentLimits).WithOne(i => i.Limit).HasForeignKey(i => i.LimitId);
            modelBuilder.Entity<Limit>().HasMany(i => i.ClientLimits).WithOne(i => i.Limit).HasForeignKey(i => i.LimitId);
            modelBuilder.Entity<Limit>().HasMany(i => i.CountryLimits).WithOne(i => i.Limit).HasForeignKey(i => i.LimitId);

            modelBuilder.Entity<Transaction>().HasKey(i => i.Id);
            modelBuilder.Entity<Transaction>().HasOne(i => i.SourceAccount).WithMany(i => i.SourceTransactions).HasForeignKey(i => i.SourceAccountId);
            modelBuilder.Entity<Transaction>().HasOne(i => i.TargetAccount).WithMany(i => i.TargetTransaction).HasForeignKey(i => i.TargetAccountId);
            modelBuilder.Entity<Transaction>().HasOne(i => i.Currency).WithMany(i => i.Transactions).HasForeignKey(i => i.CurrencyId);
            modelBuilder.Entity<Transaction>().HasOne(i => i.TransactionRequest).WithMany(i => i.Transactions).HasForeignKey(i => i.TransactionRequestId);

            modelBuilder.Entity<TransactionRequest>().HasKey(i => i.Id);
            modelBuilder.Entity<TransactionRequest>().HasOne(i => i.FromAgent).WithMany().HasForeignKey(i => i.FromAgentId);
            modelBuilder.Entity<TransactionRequest>().HasOne(i => i.ToAgent).WithMany().HasForeignKey(i => i.ToAgentId);
            modelBuilder.Entity<TransactionRequest>().HasOne(i => i.FromClient).WithMany().HasForeignKey(i => i.FromAgentId);
            modelBuilder.Entity<TransactionRequest>().HasOne(i => i.ToClient).WithMany().HasForeignKey(i => i.ToClientId);
            modelBuilder.Entity<TransactionRequest>().HasOne(i => i.FromCity).WithMany().HasForeignKey(i => i.FromCityId);
            modelBuilder.Entity<TransactionRequest>().HasOne(i => i.ToCity).WithMany().HasForeignKey(i => i.ToCityId);
            modelBuilder.Entity<TransactionRequest>().HasOne(i => i.SenderCurrency).WithMany().HasForeignKey(i => i.SenderCurrencyId);
        }


    }
}
