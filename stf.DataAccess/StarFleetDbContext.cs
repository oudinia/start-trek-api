using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using stf.DataAccess.Entities;

namespace stf.DataAccess
{
    public class StarFleetDbContext: DbContext
    {
        public DbSet<Planet> Planets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=AdventureWorks2019;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

}
