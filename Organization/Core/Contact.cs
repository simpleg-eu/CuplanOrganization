namespace Organization.Core;

/// <summary>
/// An organization's contact method, i.e. <i>Phone, +3464000000</i>.
/// </summary>
public class Contact
{
    public ContactMethod Method { get; set; }
    public string Value { get; set; }
}