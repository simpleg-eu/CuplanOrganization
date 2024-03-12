namespace Organization.Core;

public class Membership
{
    /// <summary>
    /// Unique identifier of the user.
    /// </summary>
    public string UserId { get; set; }
    /// <summary>
    /// Unique identifier of the organization.
    /// </summary>
    public string OrganizationId { get; set; }
    /// <summary>
    /// Roles of the user within the specified organization.
    /// </summary>
    public IEnumerable<Role> Roles { get; set; }
    /// <summary>
    /// Individual permissions of the user within the specified organization.
    /// </summary>
    public IEnumerable<string> Permissions { get; set; }
}