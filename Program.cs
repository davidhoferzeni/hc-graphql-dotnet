using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var connectionString = "Server=RATV-NBHOF21;Initial Catalog=LibraryDb;Persist Security Info=False;trusted_connection=yes;TrustServerCertificate=True;Connection Timeout=30;";

builder.Services.AddDbContext<DatabaseContext>(
    options => options.UseSqlServer(connectionString));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
    // db.Database.EnsureCreated();
    db.Database.Migrate();
}

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();

app.Run();
