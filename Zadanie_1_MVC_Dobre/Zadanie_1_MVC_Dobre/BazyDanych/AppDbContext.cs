using Microsoft.EntityFrameworkCore;

using Zadanie_1_MVC_Dobre.Models;


namespace PostgreSQL.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;

         
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
            
        }

        public DbSet<Klient> Klienci { get; set; }
    }
}