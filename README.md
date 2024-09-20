# DynamoDB Playground Setup

This branch (`01-DynamoDB-PlaygroundSetup`) contains the initial setup for experimenting with AWS DynamoDB using the AWS SDK for .NET. 

This playground is designed to help you understand how to interact with DynamoDB in a .NET environment, covering basic operations such as creating tables, inserting items, querying, and scanning data.

You can use this branch to follow the walkthrough guide [Using DynamoDB Locally with Docker (Part #1)
](https://medium.com/the-tech-collective/part-1-using-dynamodb-locally-with-docker-66ac7062639b).

## Intro

In this branch, we have a Minimal API with four empty endpoints:

- `GET /breweries/{id}`
- `PUT /breweries/{id}`
- `DELETE /breweries/{id}`
- `POST /breweries`

We have a `BreweryRequest` object to manage the incoming request. We also have a `BreweryResponse` object to send data back to the client. 
Lastly, there is an `endpoints.http` file that we will use to test the endpoints and an `http-client.private.env.json` file that holds variables that can be shared across our requests.


In the [main](https://github.com/nouriach/dynamodb-playground/tree/main) branch you will find the complete code.
## Features

- **AWS DynamoDB SDK for .NET**: This project uses the AWS SDK for .NET to interact with DynamoDB.
- **Basic DynamoDB Operations**: Includes examples for performing common DynamoDB operations such as:
    - Creating tables using the AWS CLI
    - Inserting items using the AWS CLI
    - Retrieving items
    - Updating items
    - Deleting items
- **Local DynamoDB Configuration**: Ability to run DynamoDB locally via Docker for testing and development purposes.
- **Endpoint Testing**: A `.http` file is provided for testing endpoints directly within your development environment.

## Prerequisites

Before running this project, ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [AWS SDK for .NET](https://aws.amazon.com/sdk-for-net/)

## Setup

**Clone the repository**:
   ```bash
   git clone https://github.com/nouriach/dynamodb-playground.git
   cd dynamodb-playground

   // access the starter branch
   git checkout 01-DynamoDB-PlaygroundSetup
