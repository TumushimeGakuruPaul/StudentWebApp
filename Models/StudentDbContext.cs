using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;

namespace StudentWebApp.Models
{
    public class StudentDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public StudentDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<CourseUnit> CourseUnits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetConnectionString(name: "DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }


    }
}