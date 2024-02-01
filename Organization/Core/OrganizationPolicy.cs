namespace Organization.Core;

/// <summary>
/// Organization's permission management related policy.
/// </summary>
public class OrganizationPolicy
{
    public string Id { get; set; }
    public IEnumerable<Role> Roles { get; set; }
    public IEnumerable<string> Permissions { get; set; }
}