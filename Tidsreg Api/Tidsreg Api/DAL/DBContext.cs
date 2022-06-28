using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tidsreg_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Tidsreg_Api.DAL
{
    public class DBContext : DbContext
    {
        public DbSet<RegistreringsModel> registrering { get; set; }
        public DBContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlite(@"Data Source = Tidsreg.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegistreringsModel>().HasData(

            new RegistreringsModel() { Id= 1, Date = "Today", TimeUsed = 1, Customer = "Paul", ContactPerson = "Paul2", Description = "Hello", InternDescription = "Hello" }


            ) ; ;
        }
    }
}
