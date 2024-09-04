using DynamoDB.Playground.API.Models;

var builder = WebApplication.CreateBuilder();

builder.Services.AddHealthChecks();

var app = builder.Build();

app.UseHealthChecks("/health");

app.MapGet("/breweries/{id}" , (Guid id) =>
{
    return Results.Ok();
});

app.MapPut("/breweries/{id}" , (BreweryRequest breweryToUpdate, Guid id) =>
{
    return Results.Ok();
});

app.MapDelete("/breweries/{id}" , (Guid id) =>
{
    return Results.Ok();
});

app.MapPost("/breweries" , (BreweryRequest breweryToCreate) =>
{
    return Results.Ok();
});

app.Run();