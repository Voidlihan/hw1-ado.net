using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Table
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }
        public DbSet<gruppa> grupps { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A-305-03;Database=adonet_hw1;Trusted_connection=true;");
        }
    }
}