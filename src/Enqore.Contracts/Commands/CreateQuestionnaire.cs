namespace Enqore.Contracts.Commands;
public class CreateQuestionnaire : IRequest<Questionnaire>
{
    public string Title { get; init; } = string.Empty;
}

public class CreateQuestionnaireValidator : AbstractValidator<CreateQuestionnaire>
{
    public CreateQuestionnaireValidator()
    {
        RuleFor(c => c.Title).NotEmpty().WithMessage("Title cannot be empty.");
        RuleFor(c => c.Title).MaximumLength(100).WithMessage("The title cannot be longer that 100 characters.");
    }
}