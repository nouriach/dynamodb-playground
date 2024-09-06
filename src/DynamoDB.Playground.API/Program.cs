using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Runtime;
using DynamoDB.Playground.API.Interfaces;
using DynamoDB.Playground.API.Models;
using DynamoDB.Playground.API.Repositories;

var builder = WebApplication.CreateBuilder();

builder.Services.AddHealthChecks();

builder.Services.AddSingleton<IAmazonDynamoDB>(_ => 
    new AmazonDynamoDBClient(
        new BasicAWSCredentials("FAKEID", "FAKEKEY"),
        new AmazonDynamoDBConfig() { ServiceURL = "http://dynamodb-local:8000", UseHttp = true }
    ));

builder.Services.AddSingleton<IDynamoDBContext, DynamoDBContext>();

builder.Services.AddScoped<IBreweryRepository, BreweryRepository>();

var app = builder.Build();

app.UseHealthChecks("/health");

app.MapGet("/breweries/{id}", async (IBreweryRepository repo, Guid id) =>
{
    var breweryDto = await repo.GetById(id.ToString());
    if (breweryDto is null) return Results.Problem();

    var breweryResponse = new BreweryResponse
    {
        Name = breweryDto.Name,
        City = breweryDto.City,
        State = breweryDto.State,
        WebsiteUrl = breweryDto.WebsiteUrl
    };

    return Results.Ok(breweryResponse);
});

app.MapPut("/breweries/{id}", async (IBreweryRepository repo, BreweryRequest breweryToUpdate, Guid id) =>
{
    var hasUpdated = await repo.Update(breweryToUpdate, id.ToString());
    return hasUpdated ? Results.Ok() : Results.Problem();
});

app.MapDelete("/breweries/{id}", async (IBreweryRepository repo, Guid id) =>
{
    var hasDeleted = await repo.Delete(id.ToString());
    return hasDeleted ? Results.Ok() : Results.Problem();
});

app.MapPost("/breweries", async (IBreweryRepository repo, BreweryRequest breweryToCreate) =>
{
    var hasCreated = await repo.Add(breweryToCreate);
    return hasCreated ? Results.Ok() : Results.Problem();
});

app.Run();