using Models.Enums;

namespace Models.Entities;

public class Drone
{
    public int Id { get; set; }
    public int ModelId { get; set; }
    public Model Model { get; set; } = null!;

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int LandingSpotId { get; set; }

    public LandingSpot LandingSpot { get; set; } = null!;
    public DroneStatus Status { get; set; }
        
}

public class Model
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public double weight { get; set; }
    public double MaxPayload { get; set; }
    public string Dimensions { get; set; } = string.Empty;
}

public class LandingSpot
{
    public int Id { get; set; }

    public int spots { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public LandingSpotStatus Status { get; set; }
}
