using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using stf.Domain;


namespace stf.DataAccess.Context
{
    public class StarFleetDbContext : DbContext
    {
        private readonly IConfiguration _configuration = null!;

        // public StarFleetDbContext()
        // {
        //
        // }

        public StarFleetDbContext(DbContextOptions options) : base(options) { }

        //public StarFleetDbContext(IConfiguration configuration) => _configuration = configuration;

        public DbSet<Planet> Planets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("server=.;database=StarFleet;Trusted_Connection=True;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlServer(_configuration.GetConnectionString("sftConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlanetConfiguration()).Seed();
        }
    }

}
