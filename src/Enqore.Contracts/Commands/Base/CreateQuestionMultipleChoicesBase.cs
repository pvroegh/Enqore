namespace Enqore.Contracts.Commands;
public abstract class CreateQuestionMultipleChoicesBase : CreateQuestionBase
{
    public IEnumerable<Answer> PossibleChoices { get; set; } = Enumerable.Empty<Answer>();
}

public class CreateQuestionMultipleAnswersBaseValidator : AbstractValidator<CreateQuestionMultipleChoicesBase>
{
    public CreateQuestionMultipleAnswersBaseValidator()
    {
        RuleFor(v => v).SetValidator(new CreateQuestionBaseValidator());
        RuleFor(v => v.PossibleChoices).Must(v => v.Count() >= 2 && v.Count() <= 10).WithMessage("You can only specify a minimum of 2 and a maximum of 10 possible choices.");
    }
}