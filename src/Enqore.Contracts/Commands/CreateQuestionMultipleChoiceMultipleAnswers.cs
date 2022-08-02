namespace Enqore.Contracts.Commands;
public sealed class CreateQuestionMultipleChoiceMultipleAnswers : CreateQuestionMultipleChoicesBase<QuestionMultipleChoiceMultipleAnswers>
{
}

public class CreateQuestionMultipleChoiceMultipleAnswersValidator : AbstractValidator<CreateQuestionMultipleChoiceMultipleAnswers>
{
    public CreateQuestionMultipleChoiceMultipleAnswersValidator()
    {
        RuleFor(v => v).SetValidator(new CreateQuestionMultipleAnswersBaseValidator<CreateQuestionMultipleChoiceMultipleAnswers, QuestionMultipleChoiceMultipleAnswers>());
    }
}

