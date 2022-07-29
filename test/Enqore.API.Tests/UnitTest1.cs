using Enqore.Contracts;
using Enqore.Contracts.Entities;
using System;
using System.Net.Http.Json;

namespace Enqore.API.Tests;

public class UnitTest1
{
    private readonly HttpClient _client;

    public UnitTest1()
    {
        var factory = new WebApplicationFactory<Program>();
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task Test1()
    {
        var command = new CreateQuestionnaire()
        {
            Title = ""
        };
        try
        {
            var response = await _client.SendRequest<CreateQuestionnaire, Questionnaire>(command);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}