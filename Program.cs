using System.Net.Http.Json;
using System.Net.Http;

using DotNetWebApi.Post;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddOpenApi()
    .AddScoped<IPostRepository, PostRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapPostEndpoints();

app.Run();
