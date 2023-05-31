using Microsoft.EntityFrameworkCore;
using TroutBlog.Data.Entities;

namespace TroutBlog.Data
{
    public class AppDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDBContext(IConfiguration configuration) 
        {
            this.Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection"));
        }

        public DbSet<BlogPost> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
