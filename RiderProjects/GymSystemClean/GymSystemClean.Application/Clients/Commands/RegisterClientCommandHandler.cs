using GymSystemClean.Domain.Entities;
using MediatR;
using GymSystemClean.Application.Interfaces;
using GymSystemClean.Application.Clients.Commands;
using GymSystemClean.Domain.Entities;
namespace GymSystemClean.Application.Clients.Commands;

public class RegisterClientCommandHandler : IRequestHandler<RegisterClientCommand, int>
{
    private readonly IClientRepository _clientRepository;

    public RegisterClientCommandHandler(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<int> Handle(RegisterClientCommand request, CancellationToken cancellationToken)
    {
        var client = new Client
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Patronymic = request.Patronymic,
            PhoneNumber = request.PhoneNumber,
            SubscriptionId = request.SubscriptionId
        };

        var clientId = await _clientRepository.AddClientAsync(client);
        return clientId;
    }
}