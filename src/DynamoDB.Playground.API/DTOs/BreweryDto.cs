using Amazon.DynamoDBv2.DataModel;

namespace DynamoDB.Playground.API.DTOs;

[DynamoDBTable("Breweries")]
public class BreweryDto
{
    [DynamoDBHashKey("breweryId")]
    public string BreweryId { get; set; } = string.Empty;
    [DynamoDBProperty("name")]
    public string Name { get; set; } = string.Empty;
    [DynamoDBProperty("city")]
    public string City { get; set; } = string.Empty;
    [DynamoDBProperty("state")]
    public string State { get; set; } = string.Empty;
    [DynamoDBProperty("websiteUrl")]
    public string WebsiteUrl { get; set; } = string.Empty;
}