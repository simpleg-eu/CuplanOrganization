using GraphQL.Types;
using Organization.Core;

namespace Organization.Api;

public class LinkType : ObjectGraphType<Link>
{
    public LinkType()
    {
        Name = "Link";
        Description = "An organization's link, i.e. 'Website, www.domain.com'.";
        Field(l => l.Name).Description("Name of the link, i.e. 'Website'.");
        Field(l => l.Value).Description("The link itself, i.e. 'https://domain.com'");
    }
}