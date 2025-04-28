using Ims.Domain.Entities;

namespace Ims.Domain.Interfaces;

public interface IClientRepository
{
    Task AddAsync(Client client);
}
