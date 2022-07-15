namespace Enqore.Contracts.Commands.Base;
public abstract class CreateQuestionBase : IRequest<QuestionBase>
{
    public Guid QuestionnaireId { get; init; }
    public string Title { get; init; } = string.Empty;
}

public class CreateQuestionBaseValidator : AbstractValidator<CreateQuestionBase>
{
    public CreateQuestionBaseValidator()
    {
        RuleFor(x => x.QuestionnaireId).NotEmpty().WithMessage("The id of the specified questionnaire is invalid.");
        RuleFor(c => c.Title).NotEmpty().WithMessage("Title cannot be empty.");
        RuleFor(c => c.Title).MaximumLength(100).WithMessage("The title cannot be longer that 100 characters.");
    }
}