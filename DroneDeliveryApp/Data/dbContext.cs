using Microsoft.EntityFrameworkCore;
using Models.Entities;
namespace Data;

public class dbContext : DbContext
{
    // user group
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }

    // drone group
    public DbSet<Drone> Drones { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<LandingSpot> LandingSpots { get; set; }

    // package group
    public DbSet<Order> Orders { get; set; }
    public DbSet<Package> Packages { get; set; }

    public dbContext(DbContextOptions<DbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);      
    }
}