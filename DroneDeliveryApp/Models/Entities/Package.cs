using Models.Enums;

namespace Models.Entities;

public class Package
{
    public int Id { get; set; }
    public double Weight { get; set; }
    public string Dimensions { get; set; } = string.Empty;
    
    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;
}

public class Order
{
    public int Id { get; set; }
    public DateTime confirmationDate { get; set; }
    public DateTime completionDate { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    
    public ICollection<Package> Packages { get; set; } = new List<Package>();
    public OrderStatus Status { get; set; }
}