namespace Organization.Core;

/// <summary>
/// Container of identification elements of an organization.
/// </summary>
public class OrganizationIdentity
{
    public string Id { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public IEnumerable<ContactMethod> ContactMethods { get; set; }
    public IEnumerable<Link> Links { get; set; }
}