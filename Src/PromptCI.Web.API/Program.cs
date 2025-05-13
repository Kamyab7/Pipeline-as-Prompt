using PromptCI.Web.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/repositories", async () =>
{
    // TODO: Provider should be detected from the request 
    var client = ProviderFactory.CreateClient(Provider.Mock);

    var repositories = await client.GetRepositoriesAsync();

    return Results.Ok(repositories);
});

app.UseHttpsRedirection();

app.Run();