namespace Models.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    
    public ICollection<Role> Roles { get; set; } = new List<Role>();
}

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}

public class Permission
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

public class UserRole
{
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    
    public int RoleId { get; set; }
    public Role Role { get; set; } = null!;

    public DateTime GrantedAt { get; set; } = DateTime.UtcNow;
    public User GrantedBy { get; set; } = null!;
}

public class RolePermission
{
    public int RoleId { get; set; }
    public Role Role { get; set; } = null!;
    
    public int PermissionId { get; set; }
    public Permission Permission { get; set; } = null!;

    public DateTime AssignedAt { get; set; } = DateTime.UtcNow;
    public User AssignedBy { get; set; } = null!;
}