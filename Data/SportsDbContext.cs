using EntityFrameworkCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo.Data
{
    public class SportsDbContext:DbContext
    {
        public DbSet<Cricketers> Cricketers { get; set; } = null!;

        public DbSet<Footballers> Footballers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PAVAN; Initial Catalog=SportsDb; Integrated Security=true; TrustServerCertificate=True");
        }
    }
}
