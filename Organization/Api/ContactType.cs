using GraphQL.Types;
using Organization.Core;

namespace Organization.Api;

public class ContactType : ObjectGraphType<Contact>
{
    public ContactType()
    {
        Name = "Contact";
        Description = "An organization's contact method, i.e. <i>Phone, '+3464000000'.";
        Field(c => c.Method).Description("Contact method, i.e. 'Phone'.");
        Field(c => c.Value).Description("Contact value, i.e. '+3464000000'.");
    }
}