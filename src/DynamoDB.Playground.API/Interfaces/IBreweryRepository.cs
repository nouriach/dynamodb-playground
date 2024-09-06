using DynamoDB.Playground.API.DTOs;
using DynamoDB.Playground.API.Models;

namespace DynamoDB.Playground.API.Interfaces;

public interface IBreweryRepository
{
    Task<BreweryDto?> GetById(string breweryId);
    Task<bool> Add(BreweryRequest breweryToCreate);
    Task<bool> Update(BreweryRequest breweryToUpdate, string breweryId);
    Task<bool> Delete(string breweryId);
}