
using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Context
{
    public class DatabaseContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=.;Database=AspNetCoreTicket;Trusted_Connection=true;");
            
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Demand> Demands { get; set; }
    }
}
