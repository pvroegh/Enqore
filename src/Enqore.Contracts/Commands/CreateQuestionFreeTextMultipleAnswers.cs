namespace Enqore.Contracts.Commands;
public sealed class CreateQuestionFreeTextMultipleAnswers : CreateQuestionBase<QuestionFreeTextMultipleAnswers>
{
    public int NumberOfAnswers { get; init; }
}

public class CreateQuestionFreeTextMultipleAnswersValidator : AbstractValidator<CreateQuestionFreeTextMultipleAnswers>
{
    public CreateQuestionFreeTextMultipleAnswersValidator()
    {
        RuleFor(v => v.NumberOfAnswers).Must(value => value >= 2 && value <= 10).WithMessage("The number of answers must be between 2 and 10.");
    }
}