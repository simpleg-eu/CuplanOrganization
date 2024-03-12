namespace Organization.Core;

/// <summary>
/// Organization's permission management related policy.
/// </summary>
public class OrganizationPolicy
{
    /// <summary>
    /// Unique identifier of the organization.
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Roles available within the organization, without taking into account the default roles.
    /// </summary>
    public IEnumerable<Role> Roles { get; set; }
    /// <summary>
    /// Permissions of the organization, without taking into account the default organization permissions.
    /// </summary>
    public IEnumerable<string> Permissions { get; set; }
}