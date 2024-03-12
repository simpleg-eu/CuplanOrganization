namespace Organization.Core;

/// <summary>
/// Role within an organization.
/// </summary>
public class Role
{
    /// <summary>
    /// Unique identifier of the role.
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Name of the role, i.e. <i>admin</i>.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Permissions given to the role, i.e. <i>create:invitation_code, read:invitation_code</i>
    /// </summary>
    public IEnumerable<string> Permissions { get; set; }
}