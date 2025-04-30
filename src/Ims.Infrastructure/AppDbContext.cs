using Microsoft.EntityFrameworkCore;
using Ims.Domain.Entities;

namespace Ims.Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Client>(client =>
        {
            client.OwnsOne(c => c.Address);
        });
    }
}
