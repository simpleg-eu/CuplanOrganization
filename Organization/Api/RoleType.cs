using GraphQL.Types;
using Organization.Core;

namespace Organization.Api;

public class RoleType : ObjectGraphType<Role>
{
    public RoleType()
    {
        Name = "Role";
        Description = "Role within an organization.";
        Field(r => r.Name, nullable: false).Description("Name of the role, i.e. 'admin'.");
        Field(r => r.Permissions, nullable: false)
            .Description("Permissions given to the role, i.e. 'create:invitation_code, read:invitation_code'.");
    }
}