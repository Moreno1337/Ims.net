using Microsoft.EntityFrameworkCore;
using Ims.Domain.Entities;

namespace Ims.Infrastructure;

public class ImsDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }

    public ImsDbContext(DbContextOptions<ImsDbContext> options) : base(options)
    {
    }
}
