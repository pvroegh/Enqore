namespace Enqore.Contracts.Commands;
public abstract class CreateQuestionMultipleChoicesBase<TQuestion> : CreateQuestionBase<TQuestion>
    where TQuestion : QuestionBase
{
    public IEnumerable<Answer> PossibleChoices { get; set; } = Enumerable.Empty<Answer>();
}

public class CreateQuestionMultipleAnswersBaseValidator<TQuestionRequest, TQuestion> : AbstractValidator<TQuestionRequest>
    where TQuestionRequest : CreateQuestionMultipleChoicesBase<TQuestion>
    where TQuestion : QuestionBase
{
    public CreateQuestionMultipleAnswersBaseValidator()
    {
        RuleFor(v => v).SetValidator(new CreateQuestionBaseValidator<TQuestionRequest, TQuestion>());
        RuleFor(v => v.PossibleChoices).Must(v => v.Count() >= 2 && v.Count() <= 10).WithMessage("You can only specify a minimum of 2 and a maximum of 10 possible choices.");
    }
}