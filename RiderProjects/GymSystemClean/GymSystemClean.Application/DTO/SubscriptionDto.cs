namespace GymSystemClean.Application.DTO;

public class SubscriptionDto
{
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public string Conditions { get; set; } = null!;
}