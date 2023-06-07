using JWTAuthAuthentication.ContextMapping;
using JWTAuthAuthentication.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_autenticacao_JWT
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles{ get; set; }

        private IConfiguration configuration;

        public DataContext(IConfiguration _configuration)
        {
            this.configuration = _configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql(configuration["ConnectionString: Postgres"].ToString());

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new RolesMap());
        }

    }
}
