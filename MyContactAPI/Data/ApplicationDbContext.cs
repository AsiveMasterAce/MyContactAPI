using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyContactAPI.Models;

namespace MyContactAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        private readonly IConfiguration _configuration;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = _configuration.GetConnectionString("MyDatabase");

            options.UseSqlite(connectionString);
        }

        public DbSet<Contact> Contacts { get; set; }

    }
}
