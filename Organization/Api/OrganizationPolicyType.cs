using GraphQL.Types;
using Organization.Core;

namespace Organization.Api;

public class OrganizationPolicyType : ObjectGraphType<OrganizationPolicy>
{
    public OrganizationPolicyType()
    {
        Name = "OrganizationPolicy";
        Description = "Organization's permission management related policy.";
        Field(o => o.Id).Description("Unique identifier of the organization.");
        Field(o => o.Roles)
            .Description("Roles available within the organization, without taking into account the default roles.");
        Field(o => o.Permissions)
            .Description(
                "Permissions of the organization, without taking into account the default organization permissions.");
    }
}