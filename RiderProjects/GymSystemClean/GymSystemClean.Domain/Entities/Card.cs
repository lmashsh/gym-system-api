namespace GymSystemClean.Domain.Entities;

public class Card
{
    public int Id { get; set; }
    public int Number { get; set; }
    public DateTime ValidUntil { get; set; }
    
    
    public int? ClientId { get; set; }
    public Client? Client { get; set; }
}