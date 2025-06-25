using MediatR;
namespace GymSystemClean.Application.Clients.Commands;

public class RegisterClientCommand : IRequest<int>
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Patronymic { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public int SubscriptionId { get; set; } 
}