using PromptCI.Web.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/repositories", async () =>
{
    // TODO: Provider should be detected from the request 
    var client = ProviderFactory.CreateClient(Provider.Github);

    var repositories = await client.GetRepositoriesAsync();

    return Results.Ok(repositories);
});

app.UseHttpsRedirection();

app.Run();