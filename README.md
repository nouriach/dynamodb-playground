# DynamoDB Playground

This repository serves as a playground for experimenting with AWS DynamoDB in a .NET environment. The project demonstrates how to interact with DynamoDB using the AWS SDK for .NET, covering a wide range of operations such as creating tables, inserting items, querying, and scanning data.

The repo has a supporting blog series which you can find here:

[Using DynamoDB Locally with Docker (Part #1): _Setting up your DynamoDB instance successfully in Docker._](https://medium.com/the-tech-collective/part-1-using-dynamodb-locally-with-docker-66ac7062639b)


## Features

- **AWS DynamoDB SDK for .NET**: The project leverages the AWS SDK for .NET to interact with DynamoDB, providing examples of common DynamoDB operations.
- **Basic DynamoDB Operations**: Examples include:
  - Creating tables
  - Inserting items
  - Retrieving items by primary key
  - Querying and scanning tables
- **Environment Configuration**: Utilizes configuration files to handle AWS credentials and DynamoDB settings.
- **`.http` File for Endpoint Testing**: Includes a `.http` file to easily test API endpoints directly within your development environment.

## Prerequisites

Before running this project, ensure the following software is installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [AWS SDK for .NET](https://aws.amazon.com/sdk-for-net/)
- [AWS CLI](https://aws.amazon.com/cli/) (Optional, but useful for managing AWS services)

## Setup

1. **Clone the repository**:
   ```bash
   git clone https://github.com/nouriach/dynamodb-playground.git
   cd dynamodb-playground

2. **Install dependencies**:
    ```bash
    // Ensure all necessary NuGet packages are installed
    dotnet restore

3. **Run the application**:
    ```bash
    dotnet run

## Testing Endpoints
To test the DynamoDB operations via API endpoints, use the provided .http file.

## Project Structure
As this is a demo, the structure is deliberately simple.

- We use `DTOs` to retrieve data from the external data source
- An interface is used to aid with Dependency Injection
- There is a repository later to encapsulate data access
- We also have a Request and Response model to work with the HTTP request
- The entire app is package into a `Dockerfile`
- `docker-compose-tests` spins up our app, alongside the local DynamoDB instance
- We have an empty `tests` folder
  - Integration tests will be added to this project in the future