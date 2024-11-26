using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductivityControl.Models;

namespace ProductivityControl.Data
{
    public  class Context : DbContext
    {
        public DbSet<RestrictedApp> RestrictedApps { get; set; } //table
        public DbSet<UsageLog> UsageLogs { get; set; } //table

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                     @"Server=DESKTOP-71M40HB\SQLEXPRESS02;
                      Database=ProductivityDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;"
                );
        }

    }
}
