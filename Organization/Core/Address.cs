namespace Organization.Core;

/// <summary>
/// Postal address.
/// </summary>
public class Address
{
    /// <summary>
    /// ISO 3166-1 alpha-2 country code, i.e. <i>ES</i>.
    /// </summary>
    public string Country { get; set; }
    /// <summary>
    /// State or province, i.e. <i>Albacete</i>.
    /// </summary>
    public string Region { get; set; }
    /// <summary>
    /// City of the address, i.e. <i>Villarrobledo</i>.
    /// </summary>
    public string City { get; set; }
    /// <summary>
    /// Street of the address, i.e. <i>Calle Dos de Mayo</i>.
    /// </summary>
    public string Street { get; set; }
    /// <summary>
    /// Number of the address, i.e. <i>2A</i>.
    /// </summary>
    public string Number { get; set; }
    /// <summary>
    /// Additional details of the address, i.e. <i>Apartament 3, Door 4A</i>.
    /// </summary>
    public string? Additional { get; set; }
    /// <summary>
    /// Postal code of the address, i.e. <i>02600</i>.
    /// </summary>
    public string PostalCode { get; set; }
}