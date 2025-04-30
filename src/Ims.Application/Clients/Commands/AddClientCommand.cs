using Ims.Application.Clients.Requests;
using MediatR;

namespace Ims.Application.Clients.Commands;

public record AddClientCommand(AddClientRequest Request) : IRequest<int>;
