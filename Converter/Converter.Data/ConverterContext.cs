using System;
using System.Collections.Generic;
using System.Text;
using Converter.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Converter.Data
{
    public class ConverterContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Unit> Units { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDb; Initial Catalog = Converter");
        }
    }
}