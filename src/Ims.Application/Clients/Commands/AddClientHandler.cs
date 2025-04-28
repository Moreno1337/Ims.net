using MediatR;
using Ims.Domain.Interfaces;
using Ims.Domain.Entities;

namespace Ims.Application.Clients.Commands;

public class AddClientHandler : IRequestHandler<AddClientCommand, int>
{
    private readonly IClientRepository _repository;

    public AddClientHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(AddClientCommand request, CancellationToken cancellationToken)
    {
        var client = new Client(request.Teste);
        await _repository.AddAsync(client);
        return client.Id;
    }
}
