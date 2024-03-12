namespace Organization.Core;

/// <summary>
/// An organization's contact method, i.e. <i>Phone, +3464000000</i>.
/// </summary>
public class Contact
{
    /// <summary>
    /// Contact method, i.e. <i>Phone</i>.
    /// </summary>
    public ContactMethod Method { get; set; }
    /// <summary>
    /// Contact value, i.e. <i>+3464000000</i>.
    /// </summary>
    public string Value { get; set; }
}