namespace Enqore.Contracts.Commands;
public abstract class CreateQuestionMultipleAnswersBase : CreateQuestionBase
{
    public IEnumerable<Answer> PossibleAnswers { get; set; } = Enumerable.Empty<Answer>();
}

public class CreateQuestionMultipleAnswersBaseValidator : AbstractValidator<CreateQuestionMultipleAnswersBase>
{
    public CreateQuestionMultipleAnswersBaseValidator()
    {
        RuleFor(v => v).SetValidator(new CreateQuestionBaseValidator());
        RuleFor(v => v.PossibleAnswers).Must(v => v.Count() >= 2 && v.Count() <= 10).WithMessage("You can only specify a minimum of 2 and a maximum of 10 possible answers.");
    }
}