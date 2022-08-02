namespace Enqore.API.Tests;

public class ApiEndpointTests
{
    private readonly HttpClient _client;

    public ApiEndpointTests()
    {
        var factory = new WebApplicationFactory<Program>();
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task SendRequest_CommandWithValidationErrors_ThrowsValidationException()
    {
        // Arrange
        var command = new CreateQuestionnaire()
        {
            Title = string.Empty // Title cannot be empty.
        };

        // Act
        var action = async () => await _client.SendRequest<CreateQuestionnaire, Questionnaire>(command);

        // Assert
        await action.Should().ThrowAsync<ValidationException>();
    }

    [Fact]
    public async Task SendRequest_CommandWithNoValidationErrors_ReturnsExpectedResult()
    {
        // Arrange
        var command = new CreateQuestionnaire()
        {
            Title = "Valid title"
        };

        // Act
        var result = await _client.SendRequest<CreateQuestionnaire, Questionnaire>(command);

        // Assert
        result.Title.Should().Be("Valid title");
    }
}