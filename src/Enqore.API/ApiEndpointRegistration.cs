namespace Enqore.API;

public static class ApiEndpointRegistration
{
    public static void MapRequest<TRequest, TResponse>(this WebApplication app)
        where TRequest : IRequest<TResponse>
    {
        app.MapPost($"/{typeof(TRequest).Name}", async (IMediator mediator, IValidator<TRequest>? validator, TRequest request, CancellationToken cancellationToken) =>
        {
            if (validator != null)
            {
                var validationResult = await validator.ValidateAsync(request, cancellationToken);
                if (!validationResult.IsValid)
                {
                    return Results.ValidationProblem(validationResult.ToDictionary());
                }
            }

            return Results.Ok(await mediator.Send(request, cancellationToken));
        });
    }
}

public class DummyHandler : IRequestHandler<CreateQuestionnaire, Questionnaire>
{
    Task<Questionnaire> IRequestHandler<CreateQuestionnaire, Questionnaire>.Handle(CreateQuestionnaire request, CancellationToken cancellationToken)
    {
        return Task.FromResult<Questionnaire>(null);
    }
}