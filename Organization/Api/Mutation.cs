using Organization.Core;

namespace Organization.Api;

public class Mutation
{
    public async Task<Membership> CreateOrganization(string name, Address address)
    {
        return await Task.Run(() => new Membership
        {
            UserId = "1234",
            OrganizationId = "4312",
            Permissions = new List<string>(),
            Roles = new List<Role>()
        });
    }
}