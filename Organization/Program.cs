using GraphQL.Server.Ui.GraphiQL;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseGraphQLGraphiQL("/graphiql");
}

app.UseHttpsRedirection();