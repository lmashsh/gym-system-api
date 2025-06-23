namespace GymSystemClean.Domain.Entities;

public class Client
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Patronymic { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;

    public int SubscriptionId { get; set; }
    public Subscription Subscription { get; set; } = null!;
    
    public Card? Card { get; set; }
}
