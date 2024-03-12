using HotChocolate.AspNetCore;
using Organization.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.UseHttpsRedirection();

if (app.Environment.IsDevelopment()) {
    app.MapGraphQL();
}
else
{
    app.MapGraphQL().WithOptions(new GraphQLServerOptions()
    {
        Tool = { Enable = false },
        EnableGetRequests = false
    });
}

app.Run();