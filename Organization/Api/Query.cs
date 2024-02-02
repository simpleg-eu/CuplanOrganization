using Organization.Core;

namespace Organization.Api;

/// <summary>
/// Root GraphQL query type.
/// </summary>
public class Query
{
    public OrganizationIdentity GetOrganizationIdentity(string id)
    {
        return new OrganizationIdentity
        {
            Id = id,
            Name = "Le organization",
            Address = new Address
            {
                Country = "ES",
                Region = "Albacete",
                City = "Villarrobledo",
                Street = "Calle Dos de Mayo",
                Number = "2A",
                PostalCode = "02600"
            },
            ContactMethods = new List<ContactMethod>(),
            Links = new List<Link>()
        };
    }
}