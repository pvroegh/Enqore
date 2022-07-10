namespace Enqore.Contracts.Commands;
public sealed class CreateQuestionMultipleChoiceMultipleAnswers : CreateQuestionMultipleAnswersBase
{
}

public class CreateQuestionMultipleChoiceMultipleAnswersValidator : AbstractValidator<CreateQuestionMultipleChoiceMultipleAnswers>
{
    public CreateQuestionMultipleChoiceMultipleAnswersValidator()
    {
        RuleFor(v => v).SetValidator(new CreateQuestionMultipleAnswersBaseValidator());
    }
}

