using MongoDB.Driver;
using MongoDB.Entities;
using SearchService.Data;
using SearchService.Models;

var builder = WebApplication.CreateBuilder(args);
DotNetEnv.Env.Load("../.env");

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)

    // Adiciona variáveis de ambiente por último (sobrescrevem o que veio antes)
    .AddEnvironmentVariables();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

try
{
    await DbInitializer.InitDb(app);
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}

app.Run();