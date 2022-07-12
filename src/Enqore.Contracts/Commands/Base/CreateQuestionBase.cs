namespace Enqore.Contracts.Commands.Base;
public abstract class CreateQuestionBase : IRequest<Guid>
{
    public string Title { get; init; } = string.Empty;
}

public class CreateQuestionBaseValidator : AbstractValidator<CreateQuestionBase>
{
    public CreateQuestionBaseValidator()
    {
        RuleFor(c => c.Title).NotEmpty().WithMessage("Title cannot be empty.");
        RuleFor(c => c.Title).MaximumLength(100).WithMessage("The title cannot be longer that 100 characters.");
    }
}