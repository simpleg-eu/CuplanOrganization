namespace Organization.Core;

/// <summary>
/// Role within an organization.
/// </summary>
public class Role
{
    public string Name { get; set; }
    /// <summary>
    /// Permissions given to the role, i.e. <i>create:invitation_code, read:invitation_code</i>
    /// </summary>
    public IEnumerable<string> Permissions { get; set; }
}