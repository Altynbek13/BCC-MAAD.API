using BCC_MAAD.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BCC_MAAD.API
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Transfer> Transfers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Transactions)
                .WithOne(t => t.Client)
                .HasForeignKey(t => t.ClientCode)
                .HasPrincipalKey(c => c.ClientCode);

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Transfers)
                .WithOne(t => t.Client)
                .HasForeignKey(t => t.ClientCode)
                .HasPrincipalKey(c => c.ClientCode);
        }
    }
}
