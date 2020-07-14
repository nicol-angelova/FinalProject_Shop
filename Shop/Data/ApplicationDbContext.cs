namespace Shop.Data
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Data.Models;

    public class ApplicationDbContext : DbContext 
    {
        private const string ConnectionString
            = "Server=DESKTOP-4DL6923;Database=Shop;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Order> Orders{ get; set; }

        public DbSet<Client> Clients{ get; set; }
    }
}
