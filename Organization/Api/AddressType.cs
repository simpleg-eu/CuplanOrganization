using GraphQL.Types;
using Organization.Core;

namespace Organization.Api;

public class AddressType : ObjectGraphType<Address>
{
    public AddressType()
    {
        Name = "Address";
        Description = "A postal address of an Organization.";
        Field(a => a.Country, nullable: false).Description("ISO 3166-1 alpha-2 country code, i.e. 'ES'.");
        Field(a => a.Region, nullable: false).Description("State or province, i.e. 'Albacete'.");
        Field(a => a.City, nullable: false).Description("City of the address, i.e. 'Villarrobledo'.");
        Field(a => a.Street, nullable: false).Description("Street of the address, i.e. 'Calle Dos de Mayo'.");
        Field(a => a.Number, nullable: false).Description("Number of the address, i.e. '2A'.");
        Field(a => a.Additional, nullable: true)
            .Description("Additional details of the address, i.e. 'Apartment 3, Door 4A'.");
        Field(a => a.PostalCode, nullable: true).Description("Postal code of the address, i.e. '02600'.");
    }
}