namespace DynamoDB.Playground.API.Models;

public class BreweryRequest
{
    public string Name { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string WebsiteUrl { get; set; } = null!;
}