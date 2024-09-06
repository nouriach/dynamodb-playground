using Amazon.DynamoDBv2.DataModel;
using DynamoDB.Playground.API.DTOs;
using DynamoDB.Playground.API.Interfaces;
using DynamoDB.Playground.API.Models;

namespace DynamoDB.Playground.API.Repositories;

public class BreweryRepository : IBreweryRepository
{
    private readonly IDynamoDBContext _dynamoDbContext;

    public BreweryRepository(IDynamoDBContext dynamoDbContext)
    {
        _dynamoDbContext = dynamoDbContext;
    }
    
    public async Task<BreweryDto?> GetById(string breweryId)
    {
        var brewery = await _dynamoDbContext.LoadAsync<BreweryDto>(breweryId);
        return brewery;
    }

    public async Task<bool> Add(BreweryRequest breweryToCreate)
    {
        var breweryDto = new BreweryDto
        {
            BreweryId = Guid.NewGuid().ToString(),
            Name = breweryToCreate.Name,
            City = breweryToCreate.City,
            State = breweryToCreate.State,
            WebsiteUrl = breweryToCreate.WebsiteUrl
        };

        await _dynamoDbContext.SaveAsync(breweryDto);
        return true;
    }

    public async Task<bool> Update(BreweryRequest breweryToUpdate, string breweryId)
    {
        var breweryRetrieved = await GetById(breweryId);

        if (breweryRetrieved is null) return false;

        breweryRetrieved.Name = breweryToUpdate.Name ?? breweryRetrieved.Name;
        breweryRetrieved.City = breweryToUpdate.City ?? breweryRetrieved.City;
        breweryRetrieved.State = breweryToUpdate.State ?? breweryRetrieved.State;
        breweryRetrieved.WebsiteUrl = breweryToUpdate.WebsiteUrl ?? breweryRetrieved.WebsiteUrl;

        await _dynamoDbContext.SaveAsync(breweryRetrieved);
        return true;
    }

    public async Task<bool> Delete(string breweryId)
    {
        await _dynamoDbContext.DeleteAsync<BreweryDto>(breweryId);
        return true;
    }
}