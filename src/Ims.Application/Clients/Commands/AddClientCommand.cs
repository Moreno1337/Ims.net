using MediatR;

namespace Ims.Application.Clients.Commands;

public record AddClientCommand(string Teste) : IRequest<int>;
