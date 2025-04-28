using Ims.Domain.Entities;
using Ims.Domain.Interfaces;

namespace Ims.Infrastructure.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly ImsDbContext _context;

    public ClientRepository(ImsDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Client client)
    {
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();
    }
}
