using GymSystemClean.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
namespace GymSystemClean.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Client> Clients { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>()
            .HasOne(c => c.Subscription)
            .WithMany(s => s.Clients)
            .HasForeignKey(c => c.SubscriptionId);
        
        modelBuilder.Entity<Client>()
            .HasOne(c => c.Card)
            .WithOne(c => c.Client)
            .HasForeignKey<Card>(x => x.ClientId);
    }

} 