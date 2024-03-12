namespace Organization.Core;

/// <summary>
/// An organization's link, i.e. <i>Website, www.domain.com</i>.
/// </summary>
public class Link
{
    /// <summary>
    /// Name of the link, i.e. <i>Website</i>.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// The link itself, i.e. <i>https://domain.com</i>.
    /// </summary>
    public string Value { get; set; }
}