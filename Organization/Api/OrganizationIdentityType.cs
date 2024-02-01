using GraphQL.Types;
using Organization.Core;

namespace Organization.Api;

public class OrganizationIdentityType : ObjectGraphType<OrganizationIdentity>
{
    public OrganizationIdentityType()
    {
        Name = "OrganizationIdentity";
        Description = "Container of identification elements of an organization.";
        Field(o => o.Id, nullable: false).Description("Unique identifier of the organization.");
        Field(o => o.Name, nullable: false).Description("Name of the organization.");
        Field(o => o.Address, nullable: false).Description("Address of the organization.");
        Field(o => o.ContactMethods, nullable: false).Description("Contact methods of the organization.");
        Field(o => o.Links, nullable: false).Description("Links of the organization.");
    }
}