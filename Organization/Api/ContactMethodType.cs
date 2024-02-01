using GraphQL.Types;
using Organization.Core;

namespace Organization.Api;

public class ContactMethodType : EnumerationGraphType<ContactMethod>
{
    public ContactMethodType()
    {
        Name = "ContactMethod";
        Description = "Contact methodology, i.e. 'Phone'.";
    }
}