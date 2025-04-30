using MediatR;
using Ims.Domain.Interfaces;
using Ims.Domain.Entities;
using Ims.Domain.ValueObjects;

namespace Ims.Application.Clients.Commands;

public class AddClientHandler : IRequestHandler<AddClientCommand, int>
{
    private readonly IClientRepository _repository;

    public AddClientHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(AddClientCommand command, CancellationToken cancellationToken)
    {
        var dto = command.Request;

        var address = new Address(
            dto.Address.Country,
            dto.Address.State,
            dto.Address.City,
            dto.Address.ZipCode,
            dto.Address.Neighborhood,
            dto.Address.Street,
            dto.Address.Number,
            dto.Address.Complement
        );

        var client = new Client(
            0,
            dto.Type,
            dto.CPF,
            dto.Name,
            true,
            dto.DateOfBirth,
            dto.StateRegistration,
            dto.CNPJ,
            dto.CompanyName,
            dto.FantasyName,
            dto.BillingTerm,
            dto.Telephone,
            dto.Cellphone,
            address,
            dto.Observations,
            dto.EmailList,
            dto.Fees,
            dto.Fine,
            dto.TotalValueInDebit
        );

        await _repository.AddAsync(client);
        return client.Id;
    }
}
