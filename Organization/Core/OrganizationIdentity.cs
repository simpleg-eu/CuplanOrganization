namespace Organization.Core;

/// <summary>
/// Container of identification elements of an organization.
/// </summary>
public class OrganizationIdentity
{
    /// <summary>
    /// Unique identifier of the organization.
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Name of the organization.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Address of the organization.
    /// </summary>
    public Address Address { get; set; }
    /// <summary>
    /// Contact methods of the organization.
    /// </summary>
    public IEnumerable<ContactMethod> ContactMethods { get; set; }
    /// <summary>
    /// Links of the organization.
    /// </summary>
    public IEnumerable<Link> Links { get; set; }
}