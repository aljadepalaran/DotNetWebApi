using System.Net.Http.Json;
using System.Net.Http;
using DotNetWebApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/posts", async () =>
{
    var postsClient = new HttpClient();
    var post = await postsClient.GetFromJsonAsync<Post>(
        "https://jsonplaceholder.typicode.com/posts/1"
    );
    return (post != null) ? post.Body : "null";
}).WithName("LoremIpsum");

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
