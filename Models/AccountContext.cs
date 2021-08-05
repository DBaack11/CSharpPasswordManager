using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFinal_PasswordManager.Models
{
    public class AccountContext : IdentityDbContext<User>
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    AccountId = 1,
                    Resource = "Test",
                    Link = "Test",
                    Email = "Test@Test.com",
                    Username = "Test",
                    Password = "Test",
                    AccountUser = ""
                },

                new Account
                {
                    AccountId = 2,
                    Resource = "DMACC",
                    Link = "https://www.dmacc.edu/Pages/welcome.aspx",
                    Email = "dfbaack@dmacc.edu",
                    Username = "dfbaack",
                    Password = "password",
                    AccountUser = ""
                }

                );
        }
    }
}
