namespace GymSystemClean.Domain.Entities;

public class Subscription
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public string Conditions { get; set; } = null!;
    
    public ICollection<Client> Clients { get; set; } = new List<Client>();


}